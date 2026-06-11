using System.Collections.Generic;
using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

public class ContactGroup
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("contacts")]
    public List<Contact> Contacts { get; set; }
}

public class Contact
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("value")]
    public string Value { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }
}
