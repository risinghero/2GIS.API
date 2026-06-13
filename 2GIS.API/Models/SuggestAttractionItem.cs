using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Attraction item.
/// </summary>
public class SuggestAttractionItem : SuggestItemBase
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
    /// Description text.
    /// </summary>
    [JsonProperty("description")]
    public string Description { get; set; }

    /// <summary>
    /// Since value.
    /// </summary>
    [JsonProperty("since")]
    public string Since { get; set; }

    /// <summary>
    /// Subtype name.
    /// </summary>
    [JsonProperty("subtype_name")]
    public string SubtypeName { get; set; }

    /// <summary>
    /// Authors.
    /// </summary>
    [JsonProperty("authors")]
    public string Authors { get; set; }

    /// <summary>
    /// Address comment.
    /// </summary>
    [JsonProperty("address_comment")]
    public string AddressComment { get; set; }

    /// <summary>
    /// Full name.
    /// </summary>
    [JsonProperty("full_name")]
    public string FullName { get; set; }

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
