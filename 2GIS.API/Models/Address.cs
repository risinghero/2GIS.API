using System.Collections.Generic;
using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

public class Address
{
    [JsonProperty("building_name")]
    public string BuildingName { get; set; }

    [JsonProperty("components")]
    public List<AddressComponent> Components { get; set; }

    [JsonProperty("postcode")]
    public string Postcode { get; set; }
}

public class AddressComponent
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("street")]
    public string Street { get; set; }

    [JsonProperty("number")]
    public string Number { get; set; }
}
