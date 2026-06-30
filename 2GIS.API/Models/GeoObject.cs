using System.Collections.Generic;
using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Search item.
/// </summary>
public class GeoObject
{
    /// <summary>
    /// Object id.
    /// </summary>
    [JsonProperty("id")]
    public string Id { get; set; }

    /// <summary>
    /// Object type.
    /// </summary>
    [JsonProperty("type")]
    public string Type { get; set; }

    /// <summary>
    /// Object name.
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// Full name.
    /// </summary>
    [JsonProperty("full_name")]
    public string FullName { get; set; }

    /// <summary>
    /// Caption text.
    /// </summary>
    [JsonProperty("caption")]
    public string Caption { get; set; }

    /// <summary>
    /// Object point.
    /// </summary>
    [JsonProperty("point")]
    public Point? Point { get; set; }

    /// <summary>
    /// Object address.
    /// </summary>
    [JsonProperty("address")]
    public Address? Address { get; set; }

    /// <summary>
    /// Object address name.
    /// </summary>
    [JsonProperty("address_name")]
    public string? AddressName { get; set; }

    /// <summary>
    /// Object building name.
    /// </summary>
    [JsonProperty("building_name")]
    public string? BuildingName { get; set; }

    /// <summary>
    /// Object purpose name.
    /// </summary>
    [JsonProperty("purpose_name")]
    public string? PurposeName { get; set; }

    /// <summary>
    /// Admin divisions.
    /// </summary>
    [JsonProperty("adm_div")]
    public List<AdmDiv> AdmDiv { get; set; }

    /// <summary>
    /// Object geometry.
    /// </summary>
    [JsonProperty("geometry")]
    public Geometry Geometry { get; set; }

    /// <summary>
    /// Object rubrics.
    /// </summary>
    [JsonProperty("rubrics")]
    public List<Rubric> Rubrics { get; set; }

    /// <summary>
    /// Extended name.
    /// </summary>
    [JsonProperty("name_ex")]
    public NameEx NameEx { get; set; }

    /// <summary>
    /// Organization info.
    /// </summary>
    [JsonProperty("org")]
    public Org Org { get; set; }

    /// <summary>
    /// Brand info.
    /// </summary>
    [JsonProperty("brand")]
    public Brand Brand { get; set; }

    /// <summary>
    /// Object flags.
    /// </summary>
    [JsonProperty("flags")]
    public Flags Flags { get; set; }

    /// <summary>
    /// Review info.
    /// </summary>
    [JsonProperty("reviews")]
    public Reviews Reviews { get; set; }

    /// <summary>
    /// Schedule info.
    /// </summary>
    [JsonProperty("schedule")]
    public Schedule Schedule { get; set; }

    /// <summary>
    /// Contact groups.
    /// </summary>
    [JsonProperty("contact_groups")]
    public List<ContactGroup> ContactGroups { get; set; }

    /// <summary>
    /// Date info.
    /// </summary>
    [JsonProperty("dates")]
    public Dates Dates { get; set; }

    /// <summary>
    /// Related links.
    /// </summary>
    [JsonProperty("links")]
    public Links Links { get; set; }

    /// <summary>
    /// Context info.
    /// </summary>
    [JsonProperty("context")]
    public Context Context { get; set; }

    /// <summary>
    /// Search info.
    /// </summary>
    [JsonProperty("search_attributes")]
    public SearchAttributes SearchAttributes { get; set; }
}
