using DiGi.BDL.Classes;
using System;

namespace DiGi.BDL
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the construction period a census variable counts (DiGi-Organization/DiGi.BDL#1).
        /// </summary>
        /// <param name="enum">The enumeration value to evaluate.</param>
        /// <returns>The YearBuiltRange attribute if found; otherwise, null - also for a total or any variable that is not a count by construction period.</returns>
        public static YearBuiltRange? YearBuiltRange(this Enum? @enum)
        {
            return CustomAttribute<YearBuiltRange>(@enum);
        }
    }
}
