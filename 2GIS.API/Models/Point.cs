using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

public class Point
{
    [JsonProperty("lon")]
    public double Lon { get; set; }

    [JsonProperty("lat")]
    public double Lat { get; set; }
}
