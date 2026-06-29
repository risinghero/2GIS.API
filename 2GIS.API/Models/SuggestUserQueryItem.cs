using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// User query item.
/// </summary>
public class SuggestUserQueryItem : SuggestItemBase
{
    /// <summary>
    /// Search attributes.
    /// </summary>
    [JsonProperty("search_attributes")]
    public SearchAttributes SearchAttributes { get; set; }
}
