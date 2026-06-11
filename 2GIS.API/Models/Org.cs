using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Organization.
/// </summary>
public class Org
{
    /// <summary>
    /// Organization id.
    /// </summary>
    [JsonProperty("id")]
    public string Id { get; set; }

    /// <summary>
    /// Organization name.
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// Branch count.
    /// </summary>
    [JsonProperty("branch_count")]
    public int BranchCount { get; set; }
}
