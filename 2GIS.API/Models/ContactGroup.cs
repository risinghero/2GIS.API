using System.Collections.Generic;
using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Contact group.
/// </summary>
public class ContactGroup
{
    /// <summary>
    /// Group name.
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// Group contacts.
    /// </summary>
    [JsonProperty("contacts")]
    public List<Contact> Contacts { get; set; }
}

/// <summary>
/// Contact info.
/// </summary>
public class Contact
{
    /// <summary>
    /// Contact type.
    /// </summary>
    [JsonProperty("type")]
    public string Type { get; set; }

    /// <summary>
    /// Contact value.
    /// </summary>
    [JsonProperty("value")]
    public string Value { get; set; }

    /// <summary>
    /// Contact url.
    /// </summary>
    [JsonProperty("url")]
    public string Url { get; set; }
}
