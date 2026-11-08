using DiGi.BDL.Classes;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DiGi.BDL
{
    public static partial class Create
    {
        /// <summary>
        /// Asynchronously retrieves a list of units from the API endpoint.
        /// </summary>
        /// <param name="pageSize">The number of records to retrieve per page.</param>
        /// <param name="clientId">Optional BDL API client identifier (API key) passed in the X-ClientId header.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a list of <see cref="Unit"/> objects, or null if no data is returned.</returns>
        public static async Task<List<Unit>?> Units(int pageSize = 100, string? clientId = null)
        {
            string url = string.Format(CultureInfo.CurrentCulture, "{0}/{1}?format=json", Constants.Url.EndPoint, Constants.Url.Id.Units);

            List<JsonObject>? jsonObjects = await JsonObjects(url, pageSize, clientId);
            if (jsonObjects == null)
            {
                return null;
            }

            List<Unit> result = [];
            foreach (JsonObject jsonObject in jsonObjects)
            {
                UnitsResponse? unitsResponse = JsonSerializer.Deserialize<UnitsResponse>(jsonObject);
                if (unitsResponse == null)
                {
                    continue;
                }

                result.AddRange(unitsResponse.results);
            }

            return result;
        }
    }
}