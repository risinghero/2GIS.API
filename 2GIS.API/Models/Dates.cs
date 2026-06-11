using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

public class Dates
{
    [JsonProperty("updated_at")]
    public string UpdatedAt { get; set; }

    [JsonProperty("created_at")]
    public string CreatedAt { get; set; }
}
