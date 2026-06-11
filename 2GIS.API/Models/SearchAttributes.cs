using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

public class SearchAttributes
{
    [JsonProperty("suggest_parts")]
    public SuggestParts SuggestParts { get; set; }

    [JsonProperty("suggested_text")]
    public string SuggestedText { get; set; }
}

public class SuggestParts
{
}
