using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

public class AdmDiv
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }
}
