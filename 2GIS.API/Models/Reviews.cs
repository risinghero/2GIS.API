using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

public class Reviews
{
    [JsonProperty("general_rating")]
    public double GeneralRating { get; set; }

    [JsonProperty("general_review_count")]
    public int GeneralReviewCount { get; set; }
}
