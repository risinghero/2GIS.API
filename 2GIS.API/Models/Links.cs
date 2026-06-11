using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

public class Links
{
    [JsonProperty("self")]
    public SelfLink Self { get; set; }
}

public class SelfLink
{
    [JsonProperty("href")]
    public string Href { get; set; }
}
