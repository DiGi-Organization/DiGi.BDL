using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading;
using System.Threading.Tasks;

namespace DiGi.BDL
{
    public static partial class Create
    {
        /// <summary>
        /// Asynchronously retrieves a list of <see cref="JsonObject"/> instances from the specified URL,
        /// automatically following pagination links until all data is collected.
        /// <para>A page refused for exceeding a rate limit (HTTP 429) is requested again after the wait its <c>Retry-After</c> header gives (BDL writes it as "<c>913 sek</c>"), up to <paramref name="retryCount"/> times, when that wait is at most <paramref name="retryMaxWaitSeconds"/>; a longer wait - a 12-hour or 7-day quota - fails at once (DiGi-Organization/DiGi.GIS.PostgreSQL#149). Any other failure, a security block of the client's address included (an HTML page with HTTP 500), fails at once.</para>
        /// </summary>
        /// <param name="url">The starting URL to fetch JSON objects from.</param>
        /// <param name="pageSize">The number of records to request per page. Defaults to 100.</param>
        /// <param name="clientId">Optional BDL API client identifier (API key) passed in the X-ClientId header. Without it the anonymous limits apply.</param>
        /// <param name="retryCount">The number of times a page refused for a rate limit is requested again.</param>
        /// <param name="retryMaxWaitSeconds">The longest wait, in seconds, a retry waits for.</param>
        /// <returns>A list of <see cref="JsonObject"/> if the operation is successful; otherwise, null.</returns>
        public static async Task<List<JsonObject>?> JsonObjects(string? url, int pageSize = 100, string? clientId = null, int retryCount = 3, int retryMaxWaitSeconds = 60)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                return null;
            }

            HttpClient httpClient = new();

            List<JsonObject>? result = [];

            try
            {
                string? url_Temp = string.Format(CultureInfo.InvariantCulture, "{0}&page-size={1}", url, pageSize);
                int retry = 0;

                do
                {
                    using HttpRequestMessage request = new(HttpMethod.Get, url_Temp);
                    if (!string.IsNullOrWhiteSpace(clientId))
                    {
                        request.Headers.Add("X-ClientId", clientId);
                    }

                    using HttpResponseMessage response = await httpClient.SendAsync(request);
                    if ((int)response.StatusCode == 429)
                    {
                        // BDL writes the wait as "913 sek", which the typed RetryAfter header cannot parse: read the leading digits.
                        int retryAfterSeconds = -1;
                        if (response.Headers.TryGetValues("Retry-After", out IEnumerable<string>? values_RetryAfter))
                        {
                            foreach (string value_RetryAfter in values_RetryAfter)
                            {
                                string digits = new([.. value_RetryAfter.Trim().TakeWhile(char.IsDigit)]);
                                if (int.TryParse(digits, NumberStyles.None, CultureInfo.InvariantCulture, out int seconds))
                                {
                                    retryAfterSeconds = seconds;
                                    break;
                                }
                            }
                        }

                        if (retry >= retryCount || retryAfterSeconds < 0 || retryAfterSeconds > retryMaxWaitSeconds)
                        {
                            return null;
                        }

                        retry++;
                        await Task.Delay(TimeSpan.FromSeconds(retryAfterSeconds + 1));
                        continue;
                    }

                    response.EnsureSuccessStatusCode();
                    retry = 0;

                    string json = await response.Content.ReadAsStringAsync();

                    if (!string.IsNullOrWhiteSpace(json))
                    {
                        JsonObject? jsonObject = JsonSerializer.Deserialize<JsonObject>(json);

                        if (jsonObject != null)
                        {
                            result.Add(jsonObject);

                            url_Temp = null;

                            if (jsonObject.TryGetPropertyValue("links", out JsonNode? jsonNode) && jsonNode is JsonObject jsonObject_Temp)
                            {
                                if (jsonObject_Temp.TryGetPropertyValue("next", out jsonNode))
                                {
                                    url_Temp = jsonNode?.AsValue().GetValue<string>();
                                }
                            }

                            if (!string.IsNullOrWhiteSpace(url_Temp))
                            {
                                await Task.Delay(100);
                            }
                        }
                    }
                }
                while (!string.IsNullOrWhiteSpace(url_Temp));
            }
            catch
            {
                result = null;
            }

            return result;
        }
    }
}