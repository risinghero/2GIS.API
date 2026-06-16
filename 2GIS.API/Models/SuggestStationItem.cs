using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Station item.
/// </summary>
public class SuggestStationItem : SuggestItemBase
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
    /// Route logo.
    /// </summary>
    [JsonProperty("route_logo")]
    public string RouteLogo { get; set; }

    /// <summary>
    /// Route type.
    /// </summary>
    [JsonProperty("route_type")]
    public string RouteType { get; set; }

    /// <summary>
    /// Color value.
    /// </summary>
    [JsonProperty("color")]
    public string Color { get; set; }

    /// <summary>
    /// Timezone.
    /// </summary>
    [JsonProperty("timezone")]
    public string Timezone { get; set; }

    /// <summary>
    /// Routing flag.
    /// </summary>
    [JsonProperty("is_routing_available")]
    public bool? IsRoutingAvailable { get; set; }

    /// <summary>
    /// Timezone offset.
    /// </summary>
    [JsonProperty("timezone_offset")]
    public int? TimezoneOffset { get; set; }

    /// <summary>
    /// Subtype value.
    /// </summary>
    [JsonProperty("subtype")]
    public string Subtype { get; set; }
}
