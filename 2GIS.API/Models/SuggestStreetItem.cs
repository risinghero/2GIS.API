using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Street item.
/// </summary>
public class SuggestStreetItem : SuggestItemBase
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
    /// Locale value.
    /// </summary>
    [JsonProperty("locale")]
    public string Locale { get; set; }

    /// <summary>
    /// City alias.
    /// </summary>
    [JsonProperty("city_alias")]
    public string CityAlias { get; set; }

    /// <summary>
    /// Full name.
    /// </summary>
    [JsonProperty("full_name")]
    public string FullName { get; set; }

    /// <summary>
    /// Routing flag.
    /// </summary>
    [JsonProperty("is_routing_available")]
    public bool? IsRoutingAvailable { get; set; }
}
