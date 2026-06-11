using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

public class NameEx
{
    [JsonProperty("primary")]
    public string Primary { get; set; }

    [JsonProperty("extension")]
    public string Extension { get; set; }
}
