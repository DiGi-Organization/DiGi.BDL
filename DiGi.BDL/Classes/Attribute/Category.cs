using DiGi.BDL.Constants;
using System;

namespace DiGi.BDL.Classes
{
    /// <summary>
    /// Attribute used to categorize a field with a specific identifier and name.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1710:Identifiers should have correct suffix", Justification = "Public attribute named by the BDL concept and returned by Query.Category; renaming is a breaking change.")]
    public class Category : Attribute
    {
        /// <summary>
        /// Gets the unique identifier of the category.
        /// </summary>
        public string? Id { get; }

        /// <summary>
        /// Gets the descriptive name of the category.
        /// </summary>
        public string? Name { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Category"/> class with a specified identifier and name.
        /// </summary>
        /// <param name="id">The unique identifier for the category.</param>
        /// <param name="name">The descriptive name for the category.</param>
        public Category(string? id, string? name)
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Category"/> class with a specified identifier,
        /// resolving the name automatically.
        /// </summary>
        /// <param name="id">The unique identifier for the category.</param>
        public Category(string? id)
        {
            Id = id;
            Name = Query.Name(typeof(Name.Category), id);
        }
    }
}