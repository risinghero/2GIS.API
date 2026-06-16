using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Admin division item.
/// </summary>
public class SuggestAdmDivItem : SuggestItemBase
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
    /// Detailed subtype.
    /// </summary>
    [JsonProperty("detailed_subtype")]
    public string DetailedSubtype { get; set; }

    /// <summary>
    /// Settlement group name.
    /// </summary>
    [JsonProperty("settlements_group_name")]
    public string SettlementsGroupName { get; set; }

    /// <summary>
    /// Locale value.
    /// </summary>
    [JsonProperty("locale")]
    public string Locale { get; set; }

    /// <summary>
    /// Description text.
    /// </summary>
    [JsonProperty("description")]
    public string Description { get; set; }

    /// <summary>
    /// Subtype specification.
    /// </summary>
    [JsonProperty("subtype_specification")]
    public string SubtypeSpecification { get; set; }

    /// <summary>
    /// Subtype.
    /// </summary>
    [JsonProperty("subtype")]
    public string Subtype { get; set; }

    /// <summary>
    /// Routing flag.
    /// </summary>
    [JsonProperty("is_routing_available")]
    public bool? IsRoutingAvailable { get; set; }
}
