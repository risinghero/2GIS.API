using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Object rubric.
/// </summary>
public class Rubric
{
    /// <summary>
    /// Rubric id.
    /// </summary>
    [JsonProperty("id")]
    public string Id { get; set; }

    /// <summary>
    /// Rubric name.
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// Rubric kind.
    /// </summary>
    [JsonProperty("kind")]
    public string Kind { get; set; }
}
