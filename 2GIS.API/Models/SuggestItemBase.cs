using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Suggest item.
/// </summary>
public abstract class SuggestItemBase : GeoObject
{
    /// <summary>
    /// Item id.
    /// </summary>
    [JsonProperty("id")]
    public string Id { get; set; }

    /// <summary>
    /// Item type.
    /// </summary>
    [JsonProperty("type")]
    public string Type { get; set; }

    /// <summary>
    /// Item name.
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// Item caption.
    /// </summary>
    [JsonProperty("caption")]
    public string Caption { get; set; }

    [JsonExtensionData]
    private IDictionary<string, JToken> AdditionalDataInternal { get; set; }

    /// <summary>
    /// Extra fields.
    /// </summary>
    public IReadOnlyDictionary<string, JToken> AdditionalData =>
        (IReadOnlyDictionary<string, JToken>)(AdditionalDataInternal ?? new Dictionary<string, JToken>());
}
