using DiGi.BDL.Constants;
using System;

namespace DiGi.BDL.Classes
{
    /// <summary>
    /// Attribute used to categorize fields into a specific subgroup.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1710:Identifiers should have correct suffix", Justification = "Public attribute named by the BDL concept and returned by Query.SubGroup; renaming is a breaking change.")]
    public class SubGroup : Attribute
    {
        /// <summary>
        /// Gets the unique identifier of the subgroup.
        /// </summary>
        public string? Id { get; }

        /// <summary>
        /// Gets the descriptive name of the subgroup.
        /// </summary>
        public string? Name { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubGroup"/> class with a specified identifier and name.
        /// </summary>
        /// <param name="id">The unique identifier for the subgroup.</param>
        /// <param name="name">The descriptive name for the subgroup.</param>
        public SubGroup(string? id, string? name)
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubGroup"/> class with a specified identifier.
        /// The name is automatically resolved using the provided identifier.
        /// </summary>
        /// <param name="id">The unique identifier for the subgroup.</param>
        public SubGroup(string? id)
        {
            Id = id;
            Name = Query.Name(typeof(Name.SubGroup), id);
        }
    }
}