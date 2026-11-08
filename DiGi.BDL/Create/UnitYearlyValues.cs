using DiGi.BDL.Classes;
using DiGi.BDL.Enums;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DiGi.BDL
{
    public static partial class Create
    {
        /// <summary>
        /// Retrieves yearly values for a specific unit based on the provided variables and years.
        /// </summary>
        /// <param name="unitId">The unique identifier of the unit.</param>
        /// <param name="variables">A collection of variables to retrieve data for.</param>
        /// <param name="years">A collection of years for which to retrieve data.</param>
        /// <param name="pageSize">The number of results per page.</param>
        /// <param name="variablesMaxCount">The maximum number of variables to process in a single request batch.</param>
        /// <returns>An instance of <see cref="UnitYearlyValues"/> containing the retrieved data, or null if inputs are invalid or retrieval fails.</returns>
        public static async Task<UnitYearlyValues?> UnitYearlyValues(string? unitId, IEnumerable<Variable>? variables, IEnumerable<int>? years, int pageSize = 100, int variablesMaxCount = 50)
        {
            if (string.IsNullOrWhiteSpace(unitId) || variables == null || !variables.Any() || years == null || !years.Any())
            {
                return null;
            }

            string url = string.Format(CultureInfo.CurrentCulture, "{0}/data/by-unit/{1}?format=json", Constants.Url.EndPoint, unitId);

            foreach (int year in years)
            {
                url += string.Format(CultureInfo.CurrentCulture, "&year={0}", year);
            }

            UnitYearlyValues? result = null;

            List<Variable> variables_Temp = [.. variables];
            while (variables_Temp.Count > 0)
            {
                string url_Temp = url;

                int count = System.Math.Min(variables_Temp.Count, variablesMaxCount);

                List<Variable> variables_Range = variables_Temp.GetRange(0, count);
                variables_Temp.RemoveRange(0, count);

                foreach (Variable variable in variables_Range)
                {
                    url_Temp += string.Format(CultureInfo.CurrentCulture, "&var-id={0}", (int)variable);
                }

                List<JsonObject>? jsonObjects = await JsonObjects(url_Temp, pageSize);
                if (jsonObjects == null)
                {
                    return null;
                }

                foreach (JsonObject jsonObject in jsonObjects)
                {
                    UnitYearlyValues? unitYearlyValues = JsonSerializer.Deserialize<UnitYearlyValues>(jsonObject);
                    if (unitYearlyValues == null)
                    {
                        continue;
                    }

                    if (result == null)
                    {
                        result = unitYearlyValues;
                    }
                    else
                    {
                        result.results?.AddRange(unitYearlyValues.results);
                    }
                }
            }

            return result;
        }
    }
}