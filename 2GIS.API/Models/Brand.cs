using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Object brand.
/// </summary>
public class Brand
{
    /// <summary>
    /// Brand id.
    /// </summary>
    [JsonProperty("id")]
    public string Id { get; set; }

    /// <summary>
    /// Brand name.
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }
}
