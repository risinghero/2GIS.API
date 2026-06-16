using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Organization item.
/// </summary>
public class SuggestOrgItem : SuggestItemBase
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
    /// Address name.
    /// </summary>
    [JsonProperty("address_name")]
    public string AddressName { get; set; }

    /// <summary>
    /// Alias value.
    /// </summary>
    [JsonProperty("alias")]
    public string Alias { get; set; }

    /// <summary>
    /// Employees count.
    /// </summary>
    [JsonProperty("employees_org_count")]
    public string EmployeesOrgCount { get; set; }

    /// <summary>
    /// Building name.
    /// </summary>
    [JsonProperty("building_name")]
    public string BuildingName { get; set; }

    /// <summary>
    /// Full address name.
    /// </summary>
    [JsonProperty("full_address_name")]
    public string FullAddressName { get; set; }

    /// <summary>
    /// Timezone.
    /// </summary>
    [JsonProperty("timezone")]
    public string Timezone { get; set; }

    /// <summary>
    /// Description text.
    /// </summary>
    [JsonProperty("description")]
    public string Description { get; set; }

    /// <summary>
    /// Is deleted.
    /// </summary>
    [JsonProperty("is_deleted")]
    public bool? IsDeleted { get; set; }

    /// <summary>
    /// Timezone offset.
    /// </summary>
    [JsonProperty("timezone_offset")]
    public int? TimezoneOffset { get; set; }

    /// <summary>
    /// Locale value.
    /// </summary>
    [JsonProperty("locale")]
    public string Locale { get; set; }

    /// <summary>
    /// Address comment.
    /// </summary>
    [JsonProperty("address_comment")]
    public string AddressComment { get; set; }

    /// <summary>
    /// Purpose name.
    /// </summary>
    [JsonProperty("purpose_name")]
    public string PurposeName { get; set; }

    /// <summary>
    /// Routing flag.
    /// </summary>
    [JsonProperty("is_routing_available")]
    public bool? IsRoutingAvailable { get; set; }

    /// <summary>
    /// Tax id.
    /// </summary>
    [JsonProperty("itin")]
    public string Itin { get; set; }
}
