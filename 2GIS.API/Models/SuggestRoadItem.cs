using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Road item.
/// </summary>
public class SuggestRoadItem : SuggestItemBase
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
    /// Source url.
    /// </summary>
    [JsonProperty("source_url")]
    public string SourceUrl { get; set; }

    /// <summary>
    /// Sport route type name.
    /// </summary>
    [JsonProperty("sport_route_type_name")]
    public string SportRouteTypeName { get; set; }

    /// <summary>
    /// Locale value.
    /// </summary>
    [JsonProperty("locale")]
    public string Locale { get; set; }

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
