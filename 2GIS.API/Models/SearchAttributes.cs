using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Search attributes.
/// </summary>
public class SearchAttributes
{
    /// <summary>
    /// Handling type.
    /// </summary>
    [JsonProperty("handling_type")]
    public int? HandlingType { get; set; }

    /// <summary>
    /// Suggest parts.
    /// </summary>
    [JsonProperty("suggest_parts")]
    public SuggestPart[] SuggestParts { get; set; } = [];

    /// <summary>
    /// Suggested text.
    /// </summary>
    [JsonProperty("suggested_text")]
    public string SuggestedText { get; set; }
}

/// <summary>
/// Suggest part.
/// </summary>
public class SuggestPart
{
    /// <summary>
    /// Suggested flag.
    /// </summary>
    [JsonProperty("is_suggested")]
    public bool IsSuggested { get; set; }

    /// <summary>
    /// Text value.
    /// </summary>
    [JsonProperty("text")]
    public string Text { get; set; }
}
