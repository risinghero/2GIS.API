using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Review data.
/// </summary>
public class Reviews
{
    /// <summary>
    /// General rating.
    /// </summary>
    [JsonProperty("general_rating")]
    public double GeneralRating { get; set; }

    /// <summary>
    /// Review count.
    /// </summary>
    [JsonProperty("general_review_count")]
    public int GeneralReviewCount { get; set; }
}
