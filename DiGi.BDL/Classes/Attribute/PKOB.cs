using System;
using System.Collections.Generic;

namespace DiGi.BDL.Classes
{
    /// <summary>
    /// Attribute used to define a set of identifiers for a field.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1710:Identifiers should have correct suffix", Justification = "Public attribute named by the PKOB classification and returned by Query.PKOB; renaming is a breaking change.")]
    public class PKOB : Attribute
    {
        /// <summary>
        /// Gets the collection of identifiers associated with this attribute.
        /// </summary>
        public HashSet<short>? Ids { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PKOB"/> class with a single identifier.
        /// </summary>
        /// <param name="id">The identifier to assign.</param>
        public PKOB(short id)
        {
            Ids = [id];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PKOB"/> class with a collection of identifiers.
        /// </summary>
        /// <param name="ids">The enumerable collection of identifiers to assign.</param>
        public PKOB(IEnumerable<short>? ids)
        {
            if (ids != null)
            {
                Ids = [.. ids];
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PKOB"/> class with an array of identifiers.
        /// </summary>
        /// <param name="ids">The array of identifiers to assign.</param>
        public PKOB(short[]? ids)
        {
            if (ids != null)
            {
                Ids = [.. ids];
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PKOB"/> class with a range of identifiers.
        /// </summary>
        /// <param name="from">The starting identifier of the range.</param>
        /// <param name="to">The ending identifier of the range.</param>
        public PKOB(short from, short to)
        {
            Ids = [];
            for (short i = from; i <= to; i++)
            {
                Ids.Add(i);
            }
        }
    }
}