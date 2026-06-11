using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Extended name.
/// </summary>
public class NameEx
{
    /// <summary>
    /// Primary name.
    /// </summary>
    [JsonProperty("primary")]
    public string Primary { get; set; }

    /// <summary>
    /// Name extension.
    /// </summary>
    [JsonProperty("extension")]
    public string Extension { get; set; }
}
