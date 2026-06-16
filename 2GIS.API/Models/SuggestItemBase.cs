using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Suggest item.
/// </summary>
public abstract class SuggestItemBase : GeoObject
{

    [JsonProperty("full_address_name")]
    public string? FullAddressName { get; set; }

    [JsonExtensionData]
    private IDictionary<string, JToken> AdditionalDataInternal { get; set; }

    /// <summary>
    /// Extra fields.
    /// </summary>
    public IReadOnlyDictionary<string, JToken> AdditionalData =>
        (IReadOnlyDictionary<string, JToken>)(AdditionalDataInternal ?? new Dictionary<string, JToken>());
}
