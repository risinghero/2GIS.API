using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

public class Flags
{
    [JsonProperty("photos")]
    public bool Photos { get; set; }

    [JsonProperty("reviews")]
    public bool Reviews { get; set; }

    [JsonProperty("on_main_page")]
    public bool OnMainPage { get; set; }

    [JsonProperty("is_paid")]
    public bool IsPaid { get; set; }

    [JsonProperty("no_address")]
    public bool NoAddress { get; set; }

    [JsonProperty("deleted")]
    public bool Deleted { get; set; }
}
