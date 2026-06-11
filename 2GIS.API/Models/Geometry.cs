using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

public class Geometry
{
    [JsonProperty("centroid")]
    public string Centroid { get; set; }

    [JsonProperty("selection")]
    public string Selection { get; set; }

    [JsonProperty("hover")]
    public string Hover { get; set; }
}

