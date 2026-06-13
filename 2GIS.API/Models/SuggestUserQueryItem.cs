using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
    public JObject SearchAttributes { get; set; }
}
