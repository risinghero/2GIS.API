using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Object address.
/// </summary>
public class Address
{

    /// <summary>
    /// Building code.
    /// </summary>
    [JsonProperty("building_code")]
    public string? BuildingCode { get; set; }

    /// <summary>
    /// Buidling id.
    /// </summary>
    [JsonProperty("building_id")]
    public string? BuildingId { get; set; }

    /// <summary>
    /// Building name.
    /// </summary>
    [JsonProperty("building_name")]
    public string? BuildingName { get; set; }

    /// <summary>
    /// Landmark name.
    /// </summary>
    [JsonProperty("landmark_name")]
    public string? LandmarkName { get; set; }

    /// <summary>
    /// Address parts.
    /// </summary>
    [JsonProperty("components")]
    public AddressComponent[] Components { get; set; } = [];

    /// <summary>
    /// Postal code.
    /// </summary>
    [JsonProperty("postcode")]
    public string Postcode { get; set; }

    [JsonProperty("makani")]
    public string? Makani { get; set; }
}

/// <summary>
/// Address part.
/// </summary>
public class AddressComponent
{

    [JsonProperty("street_id")]
    public string? StreetId { get; set; }

    [JsonProperty("oktmo")]
    public string? OKTMO { get; set; }


    [JsonProperty("okato")]
    public string? OKATO { get; set; }

    /// <summary>
    /// Component type.
    /// </summary>
    [JsonProperty("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Street name.
    /// </summary>
    [JsonProperty("street")]
    public string? Street { get; set; }

    /// <summary>
    /// Building number.
    /// </summary>
    [JsonProperty("number")]
    public string? Number { get; set; }
    
    /// <summary>
    /// Location description
    /// </summary>
    [JsonProperty("comment")]
    public string? Comment {  get; set; }
}
