using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Admin division.
/// </summary>
public class AdmDiv
{
    /// <summary>
    /// Division id.
    /// </summary>
    [JsonProperty("id")]
    public string Id { get; set; }

    /// <summary>
    /// Division type.
    /// </summary>
    [JsonProperty("type")]
    public string Type { get; set; }

    /// <summary>
    /// Division name.
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }
}
