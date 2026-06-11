using System.Collections.Generic;
using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Object address.
/// </summary>
public class Address
{
    /// <summary>
    /// Building name.
    /// </summary>
    [JsonProperty("building_name")]
    public string BuildingName { get; set; }

    /// <summary>
    /// Address parts.
    /// </summary>
    [JsonProperty("components")]
    public List<AddressComponent> Components { get; set; }

    /// <summary>
    /// Postal code.
    /// </summary>
    [JsonProperty("postcode")]
    public string Postcode { get; set; }
}

/// <summary>
/// Address part.
/// </summary>
public class AddressComponent
{
    /// <summary>
    /// Component type.
    /// </summary>
    [JsonProperty("type")]
    public string Type { get; set; }

    /// <summary>
    /// Street name.
    /// </summary>
    [JsonProperty("street")]
    public string Street { get; set; }

    /// <summary>
    /// Building number.
    /// </summary>
    [JsonProperty("number")]
    public string Number { get; set; }
}
