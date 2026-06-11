using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Search attributes.
/// </summary>
public class SearchAttributes
{
    /// <summary>
    /// Suggest parts.
    /// </summary>
    [JsonProperty("suggest_parts")]
    public SuggestParts SuggestParts { get; set; }

    /// <summary>
    /// Suggested text.
    /// </summary>
    [JsonProperty("suggested_text")]
    public string SuggestedText { get; set; }
}

/// <summary>
/// Suggest parts.
/// </summary>
public class SuggestParts
{
}
