using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Suggest response.
/// </summary>
public class SuggestResponse
{
    /// <summary>
    /// Response metadata.
    /// </summary>
    [JsonProperty("meta")]
    public Meta Meta { get; set; }

    /// <summary>
    /// Response result.
    /// </summary>
    [JsonProperty("result")]
    public SuggestResult Result { get; set; }
}
