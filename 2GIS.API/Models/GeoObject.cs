using System.Collections.Generic;
using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

public class GeoObject
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("full_name")]
    public string FullName { get; set; }

    [JsonProperty("caption")]
    public string Caption { get; set; }

    [JsonProperty("point")]
    public Point Point { get; set; }

    [JsonProperty("address")]
    public Address Address { get; set; }

    [JsonProperty("adm_div")]
    public List<AdmDiv> AdmDiv { get; set; }

    [JsonProperty("geometry")]
    public Geometry Geometry { get; set; }

    [JsonProperty("rubrics")]
    public List<Rubric> Rubrics { get; set; }

    [JsonProperty("name_ex")]
    public NameEx NameEx { get; set; }

    [JsonProperty("org")]
    public Org Org { get; set; }

    [JsonProperty("brand")]
    public Brand Brand { get; set; }

    [JsonProperty("flags")]
    public Flags Flags { get; set; }

    [JsonProperty("reviews")]
    public Reviews Reviews { get; set; }

    [JsonProperty("schedule")]
    public Schedule Schedule { get; set; }

    [JsonProperty("contact_groups")]
    public List<ContactGroup> ContactGroups { get; set; }

    [JsonProperty("dates")]
    public Dates Dates { get; set; }

    [JsonProperty("links")]
    public Links Links { get; set; }

    [JsonProperty("context")]
    public Context Context { get; set; }

    [JsonProperty("search_attributes")]
    public SearchAttributes SearchAttributes { get; set; }
}
