using System.Collections.Generic;
using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// API response.
/// </summary>
public class ItemsResponse
{
    /// <summary>
    /// Response metadata.
    /// </summary>
    [JsonProperty("meta")]
    public Meta Meta { get; set; }

    /// <summary>
    /// Response result.
    /// </summary>
    [JsonProperty("result")]
    public Result Result { get; set; }
}

/// <summary>
/// Response meta.
/// </summary>
public class Meta
{
    /// <summary>
    /// API version.
    /// </summary>
    [JsonProperty("api_version")]
    public string ApiVersion { get; set; }

    /// <summary>
    /// Status code.
    /// </summary>
    [JsonProperty("code")]
    public int Code { get; set; }

    /// <summary>
    /// Issue date.
    /// </summary>
    [JsonProperty("issue_date")]
    public string IssueDate { get; set; }
}

/// <summary>
/// Response data.
/// </summary>
public class Result
{
    /// <summary>
    /// Total count.
    /// </summary>
    [JsonProperty("total")]
    public int Total { get; set; }

    /// <summary>
    /// Result items.
    /// </summary>
    [JsonProperty("items")]
    public List<GeoObject> Items { get; set; }
}
