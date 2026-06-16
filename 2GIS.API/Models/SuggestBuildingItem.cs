using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Building item.
/// </summary>
public class SuggestBuildingItem : SuggestItemBase
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
    /// Reviews count.
    /// </summary>
    [JsonProperty("allowed_for_reviews_count")]
    public int? AllowedForReviewsCount { get; set; }

    /// <summary>
    /// Purpose name.
    /// </summary>
    [JsonProperty("purpose_name")]
    public string PurposeName { get; set; }

    /// <summary>
    /// Full address name.
    /// </summary>
    [JsonProperty("full_address_name")]
    public string FullAddressName { get; set; }

    /// <summary>
    /// Building name.
    /// </summary>
    [JsonProperty("building_name")]
    public string BuildingName { get; set; }

    /// <summary>
    /// Item provider.
    /// </summary>
    [JsonProperty("item_provider")]
    public string ItemProvider { get; set; }

    /// <summary>
    /// Address name.
    /// </summary>
    [JsonProperty("address_name")]
    public string AddressName { get; set; }

    /// <summary>
    /// Routing flag.
    /// </summary>
    [JsonProperty("is_routing_available")]
    public bool? IsRoutingAvailable { get; set; }
}
