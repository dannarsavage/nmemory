namespace NMemory.Spatial
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// A data contract serializable representation of a <see cref="DbGeometry" /> value.
    /// </summary>
    public sealed class DbGeometryWellKnownValue
    {
        /// <summary> Gets or sets the coordinate system identifier (SRID) of this value. </summary>
        public int CoordinateSystemId { get; set; }

        /// <summary> Gets or sets the well known text representation of this value. </summary>
        public string WellKnownText { get; set; }

        /// <summary> Gets or sets the well known binary representation of this value. </summary>
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Justification = "Required for this feature")]
        public byte[] WellKnownBinary { get; set; }
    }
}

