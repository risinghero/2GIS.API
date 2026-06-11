using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Object flags.
/// </summary>
public class Flags
{
    /// <summary>
    /// Has photos.
    /// </summary>
    [JsonProperty("photos")]
    public bool Photos { get; set; }

    /// <summary>
    /// Has reviews.
    /// </summary>
    [JsonProperty("reviews")]
    public bool Reviews { get; set; }

    /// <summary>
    /// On main page.
    /// </summary>
    [JsonProperty("on_main_page")]
    public bool OnMainPage { get; set; }

    /// <summary>
    /// Is paid.
    /// </summary>
    [JsonProperty("is_paid")]
    public bool IsPaid { get; set; }

    /// <summary>
    /// No address.
    /// </summary>
    [JsonProperty("no_address")]
    public bool NoAddress { get; set; }

    /// <summary>
    /// Is deleted.
    /// </summary>
    [JsonProperty("deleted")]
    public bool Deleted { get; set; }
}
