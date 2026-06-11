using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Object geometry.
/// </summary>
public class Geometry
{
    /// <summary>
    /// Centroid value.
    /// </summary>
    [JsonProperty("centroid")]
    public string Centroid { get; set; }

    /// <summary>
    /// Selection value.
    /// </summary>
    [JsonProperty("selection")]
    public string Selection { get; set; }

    /// <summary>
    /// Hover value.
    /// </summary>
    [JsonProperty("hover")]
    public string Hover { get; set; }
}

