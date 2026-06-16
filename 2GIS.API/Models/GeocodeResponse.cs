using System.Collections.Generic;
using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// API response.
/// </summary>
public class GeocodeResponse
{
    /// <summary>
    /// Response metadata.
    /// </summary>
    [JsonProperty("meta")]
    public ResponseMeta Meta { get; set; }

    /// <summary>
    /// Response result.
    /// </summary>
    [JsonProperty("result")]
    public GeocodeResult Result { get; set; }
}

/// <summary>
/// Response data.
/// </summary>
public class GeocodeResult
{
    /// <summary>
    /// Total count.
    /// </summary>
    [JsonProperty("total")]
    public int Total { get; set; }

    /// <summary>
    /// Result items.
    /// </summary>
    [JsonProperty("items")]
    public List<GeoObject> Items { get; set; }
}
