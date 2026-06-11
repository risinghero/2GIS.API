using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Object dates.
/// </summary>
public class Dates
{
    /// <summary>
    /// Update date.
    /// </summary>
    [JsonProperty("updated_at")]
    public string UpdatedAt { get; set; }

    /// <summary>
    /// Create date.
    /// </summary>
    [JsonProperty("created_at")]
    public string CreatedAt { get; set; }
}
