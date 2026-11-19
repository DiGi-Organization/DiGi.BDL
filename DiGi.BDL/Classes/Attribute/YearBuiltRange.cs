using System;

namespace DiGi.BDL.Classes
{
    /// <summary>
    /// Attribute giving the construction period a census variable counts, as the years it was published with (DiGi-Organization/DiGi.BDL#1).
    /// <para>Both bounds are inclusive. A period open towards the past, such as "before 1918", has no first year.</para>
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1710:Identifiers should have correct suffix", Justification = "Named like the other BDL variable attributes (PKOB, Category) and returned by Query.YearBuiltRange.")]
    public class YearBuiltRange : Attribute
    {
        /// <summary>
        /// Gets the first year of the period, or null when the period is open towards the past.
        /// </summary>
        public short? FirstYear { get; }

        /// <summary>
        /// Gets the last year of the period.
        /// </summary>
        public short LastYear { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="YearBuiltRange"/> class for a closed period.
        /// </summary>
        /// <param name="firstYear">The first year of the period, inclusive.</param>
        /// <param name="lastYear">The last year of the period, inclusive.</param>
        public YearBuiltRange(short firstYear, short lastYear)
        {
            FirstYear = firstYear;
            LastYear = lastYear;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="YearBuiltRange"/> class for a period open towards the past.
        /// </summary>
        /// <param name="lastYear">The last year of the period, inclusive.</param>
        public YearBuiltRange(short lastYear)
        {
            LastYear = lastYear;
        }
    }
}
