using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Object context.
/// </summary>
public class Context
{
    /// <summary>
    /// Distance value.
    /// </summary>
    [JsonProperty("distance")]
    public int Distance { get; set; }
}
