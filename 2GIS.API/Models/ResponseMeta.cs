using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Response metadata.
/// </summary>
public class ResponseMeta
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

    /// <summary>
    /// Error information, if any
    /// </summary>
    [JsonProperty("error")]
    public ResponseMetaError? Error { get; set; }
}

/// <summary>
/// API response error information.
/// </summary>
public class ResponseMetaError
{
    /// <summary>
    /// Error type.
    /// </summary>
    [JsonProperty("type")]
    public string Type { get; set; }

    /// <summary>
    /// Error message.
    /// </summary>
    [JsonProperty("message")]
    public string Message { get; set; }
}
