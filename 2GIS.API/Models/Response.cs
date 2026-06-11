using System.Collections.Generic;
using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

public class ItemsResponse
{
    [JsonProperty("meta")]
    public Meta Meta { get; set; }

    [JsonProperty("result")]
    public Result Result { get; set; }
}

public class Meta
{
    [JsonProperty("api_version")]
    public string ApiVersion { get; set; }

    [JsonProperty("code")]
    public int Code { get; set; }

    [JsonProperty("issue_date")]
    public string IssueDate { get; set; }
}

public class Result
{
    [JsonProperty("total")]
    public int Total { get; set; }

    [JsonProperty("items")]
    public List<GeoObject> Items { get; set; }
}
