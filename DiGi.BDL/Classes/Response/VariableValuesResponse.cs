namespace DiGi.BDL.Classes
{
    /// <summary>
    /// Represents one page of the BDL <c>data/by-variable</c> endpoint: the values of one variable for every territorial unit of one level (DiGi-Organization/DiGi.GIS.PostgreSQL#149).
    /// </summary>
    public class VariableValuesResponse : Response<VariableUnitValues>
    {
        /// <summary>
        /// Gets or sets the identifier of the variable.
        /// </summary>
        public int variableId { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the measure unit of the variable.
        /// </summary>
        public int measureUnitId { get; set; }
    }
}
