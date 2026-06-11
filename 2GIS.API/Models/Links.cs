using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Object links.
/// </summary>
public class Links
{
    /// <summary>
    /// Self link.
    /// </summary>
    [JsonProperty("self")]
    public SelfLink Self { get; set; }
}

/// <summary>
/// Self link.
/// </summary>
public class SelfLink
{
    /// <summary>
    /// Link url.
    /// </summary>
    [JsonProperty("href")]
    public string Href { get; set; }
}
