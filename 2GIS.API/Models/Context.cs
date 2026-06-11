using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

public class Context
{
    [JsonProperty("distance")]
    public int Distance { get; set; }
}
