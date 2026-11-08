using System.Collections.Generic;
using System.Globalization;
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
        /// </summary>
        /// <param name="url">The starting URL to fetch JSON objects from.</param>
        /// <param name="pageSize">The number of records to request per page. Defaults to 100.</param>
        /// <param name="clientId">Optional BDL API client identifier (API key) passed in the X-ClientId header.</param>
        /// <returns>A list of <see cref="JsonObject"/> if the operation is successful; otherwise, null.</returns>
        public static async Task<List<JsonObject>?> JsonObjects(string? url, int pageSize = 100, string? clientId = null)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                return null;
            }

            HttpClient httpClient = new();

            List<JsonObject>? result = [];

            try
            {
                string? url_Temp = string.Format(CultureInfo.CurrentCulture, "{0}&page-size={1}", url, pageSize);

                do
                {
                    using HttpRequestMessage request = new(HttpMethod.Get, url_Temp);
                    if (!string.IsNullOrWhiteSpace(clientId))
                    {
                        request.Headers.Add("X-ClientId", clientId);
                    }

                    using HttpResponseMessage response = await httpClient.SendAsync(request);
                    response.EnsureSuccessStatusCode();

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