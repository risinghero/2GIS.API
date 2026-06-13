using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Route item.
/// </summary>
public class SuggestRouteItem : SuggestItemBase
{
    /// <summary>
    /// Region id.
    /// </summary>
    [JsonProperty("region_id")]
    public string RegionId { get; set; }

    /// <summary>
    /// Segment id.
    /// </summary>
    [JsonProperty("segment_id")]
    public string SegmentId { get; set; }

    /// <summary>
    /// Subtype value.
    /// </summary>
    [JsonProperty("subtype")]
    public string Subtype { get; set; }

    /// <summary>
    /// From name.
    /// </summary>
    [JsonProperty("from_name")]
    public string FromName { get; set; }

    /// <summary>
    /// Locale value.
    /// </summary>
    [JsonProperty("locale")]
    public string Locale { get; set; }

    /// <summary>
    /// Color value.
    /// </summary>
    [JsonProperty("color")]
    public string Color { get; set; }

    /// <summary>
    /// Description text.
    /// </summary>
    [JsonProperty("description")]
    public string Description { get; set; }

    /// <summary>
    /// To name.
    /// </summary>
    [JsonProperty("to_name")]
    public string ToName { get; set; }

    /// <summary>
    /// Route logo.
    /// </summary>
    [JsonProperty("route_logo")]
    public string RouteLogo { get; set; }
}
