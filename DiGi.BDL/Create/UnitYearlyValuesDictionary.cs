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
        /// Retrieves the values of one variable for every territorial unit of one level, keyed by unit id, from the BDL <c>data/by-variable</c> endpoint (DiGi-Organization/DiGi.GIS.PostgreSQL#149).
        /// <para>One request per page of <paramref name="pageSize"/> units - about 40 for the gmina level - instead of one per unit, so a variable missing from every unit is fetched within the BDL limits. A level the variable is not published at answers no units.</para>
        /// </summary>
        /// <param name="variable">The variable to retrieve.</param>
        /// <param name="unitLevel">The BDL unit level, 0 (country) to 6 (gmina).</param>
        /// <param name="years">The years to retrieve.</param>
        /// <param name="pageSize">The number of units per page.</param>
        /// <param name="clientId">The BDL API client identifier sent in the X-ClientId header, or null for the anonymous limits.</param>
        /// <returns>The values of the variable keyed by unit id, each as a <see cref="Classes.UnitYearlyValues"/> holding that one variable; null when the inputs are invalid or a request failed.</returns>
        public static async Task<Dictionary<string, UnitYearlyValues>?> UnitYearlyValuesDictionary(Variable variable, int unitLevel, IEnumerable<int>? years, int pageSize = 100, string? clientId = null)
        {
            if (years == null || !years.Any() || unitLevel < 0)
            {
                return null;
            }

            string url = string.Format(CultureInfo.InvariantCulture, "{0}/data/by-variable/{1}?format=json&unit-level={2}", Constants.Url.EndPoint, (int)variable, unitLevel);
            foreach (int year in years)
            {
                url += string.Format(CultureInfo.InvariantCulture, "&year={0}", year);
            }

            List<JsonObject>? jsonObjects = await JsonObjects(url, pageSize, clientId);
            if (jsonObjects == null)
            {
                return null;
            }

            return UnitYearlyValuesDictionary(variable, jsonObjects);
        }

        /// <summary>
        /// Converts the pages of the BDL <c>data/by-variable</c> endpoint for one variable into its values keyed by unit id (DiGi-Organization/DiGi.GIS.PostgreSQL#149).
        /// </summary>
        /// <param name="variable">The variable the pages hold.</param>
        /// <param name="jsonObjects">The pages, as <see cref="JsonObjects(string?, int, string?, int, int)"/> returns them.</param>
        /// <returns>One <see cref="Classes.UnitYearlyValues"/> per unit with an id, holding the one variable; a unit spread over two pages has its values joined. Empty when no page holds a unit.</returns>
        public static Dictionary<string, UnitYearlyValues> UnitYearlyValuesDictionary(Variable variable, IEnumerable<JsonObject>? jsonObjects)
        {
            Dictionary<string, UnitYearlyValues> result = [];
            if (jsonObjects == null)
            {
                return result;
            }

            foreach (JsonObject jsonObject in jsonObjects)
            {
                VariableValuesResponse? variableValuesResponse = jsonObject?.Deserialize<VariableValuesResponse>();
                if (variableValuesResponse?.results == null)
                {
                    continue;
                }

                foreach (VariableUnitValues variableUnitValues in variableValuesResponse.results)
                {
                    if (variableUnitValues?.id is not string unitId || string.IsNullOrWhiteSpace(unitId) || variableUnitValues.values == null)
                    {
                        continue;
                    }

                    if (!result.TryGetValue(unitId, out UnitYearlyValues? unitYearlyValues))
                    {
                        unitYearlyValues = new UnitYearlyValues() { unitId = unitId, unitName = variableUnitValues.name, results = [] };
                        result[unitId] = unitYearlyValues;
                    }

                    YearlyValues? yearlyValues = unitYearlyValues.results?.Find(x => x.id == (int)variable);
                    if (yearlyValues == null)
                    {
                        yearlyValues = new YearlyValues() { id = (int)variable, measureUnitId = variableValuesResponse.measureUnitId, values = [] };
                        unitYearlyValues.results?.Add(yearlyValues);
                    }

                    yearlyValues.values?.AddRange(variableUnitValues.values);
                }
            }

            return result;
        }
    }
}
