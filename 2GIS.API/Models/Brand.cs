using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

public class Brand
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }
}
