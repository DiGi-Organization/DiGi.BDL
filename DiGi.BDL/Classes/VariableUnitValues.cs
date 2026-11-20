using DiGi.BDL.Interfaces;
using System.Collections.Generic;

namespace DiGi.BDL.Classes
{
    /// <summary>
    /// Represents the values of one variable for one territorial unit, as a result of the BDL <c>data/by-variable</c> endpoint returns it (DiGi-Organization/DiGi.GIS.PostgreSQL#149).
    /// </summary>
    public class VariableUnitValues : IResultObject
    {
        /// <summary>
        /// Gets or sets the identifier of the territorial unit.
        /// </summary>
        public string? id { get; set; }

        /// <summary>
        /// Gets or sets the name of the territorial unit.
        /// </summary>
        public string? name { get; set; }

        /// <summary>
        /// Gets or sets the yearly values of the variable for the unit.
        /// </summary>
        public List<YearlyValue>? values { get; set; }
    }
}
