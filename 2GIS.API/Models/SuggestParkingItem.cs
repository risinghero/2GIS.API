using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Parking item.
/// </summary>
public class SuggestParkingItem : SuggestItemBase
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
    /// Timezone offset.
    /// </summary>
    [JsonProperty("timezone_offset")]
    public int? TimezoneOffset { get; set; }

    /// <summary>
    /// Access type.
    /// </summary>
    [JsonProperty("access")]
    public string Access { get; set; }

    /// <summary>
    /// Comment text.
    /// </summary>
    [JsonProperty("comment")]
    public string Comment { get; set; }

    /// <summary>
    /// Paving type.
    /// </summary>
    [JsonProperty("paving_type")]
    public string PavingType { get; set; }

    /// <summary>
    /// Full name.
    /// </summary>
    [JsonProperty("full_name")]
    public string FullName { get; set; }

    /// <summary>
    /// Access name.
    /// </summary>
    [JsonProperty("access_name")]
    public string AccessName { get; set; }

    /// <summary>
    /// Access comment.
    /// </summary>
    [JsonProperty("access_comment")]
    public string AccessComment { get; set; }

    /// <summary>
    /// Full address name.
    /// </summary>
    [JsonProperty("full_address_name")]
    public string FullAddressName { get; set; }

    /// <summary>
    /// Level count.
    /// </summary>
    [JsonProperty("level_count")]
    public int? LevelCount { get; set; }

    /// <summary>
    /// Truck flag.
    /// </summary>
    [JsonProperty("for_trucks")]
    public bool? ForTrucks { get; set; }

    /// <summary>
    /// Timezone.
    /// </summary>
    [JsonProperty("timezone")]
    public string Timezone { get; set; }

    /// <summary>
    /// Purpose value.
    /// </summary>
    [JsonProperty("purpose")]
    public string Purpose { get; set; }

    /// <summary>
    /// Address name.
    /// </summary>
    [JsonProperty("address_name")]
    public string AddressName { get; set; }

    /// <summary>
    /// Subtype.
    /// </summary>
    [JsonProperty("subtype")]
    public string Subtype { get; set; }

    /// <summary>
    /// Locale value.
    /// </summary>
    [JsonProperty("locale")]
    public string Locale { get; set; }

    /// <summary>
    /// Routing flag.
    /// </summary>
    [JsonProperty("is_routing_available")]
    public bool? IsRoutingAvailable { get; set; }

    /// <summary>
    /// Incentive flag.
    /// </summary>
    [JsonProperty("is_incentive")]
    public bool? IsIncentive { get; set; }

    /// <summary>
    /// Paid flag.
    /// </summary>
    [JsonProperty("is_paid")]
    public bool? IsPaid { get; set; }
}
