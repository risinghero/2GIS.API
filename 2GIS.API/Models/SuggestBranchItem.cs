using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Branch item.
/// </summary>
public class SuggestBranchItem : SuggestItemBase
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
    /// Address comment.
    /// </summary>
    [JsonProperty("address_comment")]
    public string AddressComment { get; set; }

    /// <summary>
    /// Building name.
    /// </summary>
    [JsonProperty("building_name")]
    public string BuildingName { get; set; }

    /// <summary>
    /// Description text.
    /// </summary>
    [JsonProperty("description")]
    public string Description { get; set; }

    /// <summary>
    /// Alias value.
    /// </summary>
    [JsonProperty("alias")]
    public string Alias { get; set; }

    /// <summary>
    /// Address name.
    /// </summary>
    [JsonProperty("address_name")]
    public string AddressName { get; set; }

    /// <summary>
    /// Full address name.
    /// </summary>
    [JsonProperty("full_address_name")]
    public string FullAddressName { get; set; }

    /// <summary>
    /// Full name.
    /// </summary>
    [JsonProperty("full_name")]
    public string FullName { get; set; }

    /// <summary>
    /// City alias.
    /// </summary>
    [JsonProperty("city_alias")]
    public string CityAlias { get; set; }

    /// <summary>
    /// Timezone offset.
    /// </summary>
    [JsonProperty("timezone_offset")]
    public int? TimezoneOffset { get; set; }

    /// <summary>
    /// Is deleted.
    /// </summary>
    [JsonProperty("is_deleted")]
    public bool? IsDeleted { get; set; }

    /// <summary>
    /// Routing flag.
    /// </summary>
    [JsonProperty("is_routing_available")]
    public bool? IsRoutingAvailable { get; set; }

    /// <summary>
    /// Purpose name.
    /// </summary>
    [JsonProperty("purpose_name")]
    public string PurposeName { get; set; }

    /// <summary>
    /// Tax id.
    /// </summary>
    [JsonProperty("itin")]
    public string Itin { get; set; }
}
