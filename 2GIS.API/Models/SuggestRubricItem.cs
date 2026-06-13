using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Rubric item.
/// </summary>
public class SuggestRubricItem : SuggestItemBase
{
    /// <summary>
    /// Region id.
    /// </summary>
    [JsonProperty("region_id")]
    public string RegionId { get; set; }

    /// <summary>
    /// Icon url.
    /// </summary>
    [JsonProperty("icon_url")]
    public string IconUrl { get; set; }

    /// <summary>
    /// Branch count.
    /// </summary>
    [JsonProperty("branch_count")]
    public int? BranchCount { get; set; }

    /// <summary>
    /// Org count.
    /// </summary>
    [JsonProperty("org_count")]
    public int? OrgCount { get; set; }

    /// <summary>
    /// Geo count.
    /// </summary>
    [JsonProperty("geo_count")]
    public int? GeoCount { get; set; }

    /// <summary>
    /// Item tag.
    /// </summary>
    [JsonProperty("tag")]
    public string Tag { get; set; }

    /// <summary>
    /// Item title.
    /// </summary>
    [JsonProperty("title")]
    public string Title { get; set; }

    /// <summary>
    /// Search query.
    /// </summary>
    [JsonProperty("search_query")]
    public string SearchQuery { get; set; }

    /// <summary>
    /// Suggest icon.
    /// </summary>
    [JsonProperty("suggest_icon")]
    public string SuggestIcon { get; set; }
}
