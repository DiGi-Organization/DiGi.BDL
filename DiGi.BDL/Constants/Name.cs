namespace DiGi.BDL.Constants
{
    /// <summary>
    /// Provides constant name definitions for BDL categories, groups, and subgroups.
    /// </summary>
    public static class Name
    {
        /// <summary>
        /// Contains constants for category names.
        /// </summary>
        public static class Category
        {
            /// <summary>
            /// The constant value for the Population category.
            /// </summary>
            public const string K3 = "POPULATION";

            /// <summary>
            /// The constant value for the Industry and Construction category.
            /// </summary>
            public const string K12 = "INDUSTRY AND CONSTRUCTION";

            /// <summary>
            /// The constant value for the National Censuses category.
            /// </summary>
            public const string K31 = "NATIONAL CENSUSES";
        }

        /// <summary>
        /// Contains constants for group names.
        /// </summary>
        public static class Group
        {
            /// <summary>
            /// The constant value for the Population group.
            /// </summary>
            public const string G7 = "POPULATION";

            /// <summary>
            /// The constant value for the Non-Residential Buildings group.
            /// </summary>
            public const string G602 = "NON-RESIDENTIAL BUILDINGS";

            /// <summary>
            /// The constant value for the Housing Construction group.
            /// </summary>
            public const string G603 = "HOUSING CONSTRUCTION";

            /// <summary>
            /// The constant value for the Energy Performance of Buildings group.
            /// </summary>
            public const string G643 = "ENERGY PERFORMANCE OF BUILDINGS";

            /// <summary>
            /// The constant value for the Census 2021 - Dwellings group.
            /// </summary>
            public const string G645 = "CENSUS 2021 - DWELLINGS";
        }

        /// <summary>
        /// Contains constants for subgroup names.
        /// </summary>
        public static class SubGroup
        {
            /// <summary>
            /// The constant value for the population density and indicators subgroup.
            /// </summary>
            public const string P2425 = "The population density and indicators";

            /// <summary>
            /// The constant value for the non-residential buildings, residences for communities and summer homes completed (quarterly data) subgroup.
            /// </summary>
            public const string P3812 = "Non-residential buildings, residences for communities and summer homes completed (quarterly data)";

            /// <summary>
            /// The constant value for the new residential buildings completed - floors (quarterly data) subgroup.
            /// </summary>
            public const string P4136 = "New residential buildings completed - floors (quarterly data)";

            /// <summary>
            /// The constant value for the energy performance of buildings subgroup.
            /// </summary>
            public const string P4152 = "Energy performance of buildings";

            /// <summary>
            /// The constant value for the inhabited dwellings by period of construction of a building subgroup (National Census 2021).
            /// </summary>
            public const string P4386 = "Inhabited dwellings by period of construction of a building";
        }
    }
}