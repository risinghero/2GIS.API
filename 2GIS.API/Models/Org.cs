using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

public class Org
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("branch_count")]
    public int BranchCount { get; set; }
}
