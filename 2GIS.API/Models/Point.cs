using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Coordinates.
/// </summary>
public class Point
{
    /// <summary>
    /// Longitude.
    /// </summary>
    [JsonProperty("lon")]
    public double Lon { get; set; }

    /// <summary>
    /// Latitude.
    /// </summary>
    [JsonProperty("lat")]
    public double Lat { get; set; }
}
