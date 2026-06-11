using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

public class Rubric
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("kind")]
    public string Kind { get; set; }
}
