using System.Collections.Generic;
using System.Globalization;

namespace FT.TwoGis.Api;

/// <summary>
/// Represents a request for geocoding.
/// </summary>
/// <param name="Key">The API key for authentication.</param>
public record class GeocodeRequest(string Key)
{
    /// <summary>
    /// The locale from which the search is performed and the results are given.  
    /// </summary>
    public string? Locale { get; init; }

    /// <summary>
    /// The query string for the geocoding request.
    /// </summary>
    public string? Query { get; init; }

    /// <summary>
    /// The types of geo-objects among which the search is performed. When passing several types, less relevant results of some types may be crowded out by more relevant other types. Types should be comma separated.
    /// </summary>
    public string[]? Type {  get; init; }

    /// <summary>
    /// Additional fields to be displayed in the response.
    /// </summary>
    public string[]? Fields { get; init; }

    /// <summary>
    /// Type of search.
    /// </summary>
    public string? SearchType { get; init; }

    /// <summary>
    /// Specifying to the search engine that the request is complete (the user has pressed the completion button). Disables the prefix, i.e. "bank" will not be searched "banking".
    /// </summary>
    public bool? SearchIsQueryTextComplete { get; init; }

    /// <summary>
    /// Specifying the search engine to use search mode near the user. Greatly increases the importance of distance from the user. Popularity, advertising and other parameters are still involved in the ranking, but to a lesser extent.
    /// </summary>
    public bool? SearchNearby { get; init; }

    /// <summary>
    /// Specifying the method for entering the query text to the search engine.
    /// </summary>
    public string? SearchInputMethod { get; init; }

    /// <summary>
    /// A weak search engine restriction has been established for searching for objects in the region. The WKT format is required.
    /// </summary>
    public string? SearchTerritoryOfInterest { get; init; }

    /// <summary>
    /// Sorting of results.
    /// </summary>
    public string? Sort { get; init; }

    /// <summary>
    /// The coordinates of the point from which you are sorting in the lon, lat format. Deprecated parameter, the location parameter should be used instead.
    /// </summary>
    public string? SortPoint { get; init; }

    /// <summary>
    /// User coordinates in the format lon, lat.
    /// </summary>
    public string? Location { get; init; }

    /// <summary>
    /// Longitude of the point - center of the search area.
    /// </summary>
    public double? Lon { get; init; }

    /// <summary>
    /// Latitude of the point - center of the search area.
    /// </summary>
    public double? Lat { get; init; }

    /// <summary>
    /// A center of the search area in the lon, lat format.
    /// </summary>
    public string? Point { get; init; }

    /// <summary>
    /// Search radius in meters.
    /// </summary>
    public int? Radius { get; init; }

    /// <summary>
    /// The IDs of the districts, separated by commas.
    /// </summary>
    public long[]? DistrictId { get; init; }

    /// <summary>
    /// The IDs of the buildings, separated by commas.
    /// </summary>
    public long[]? BuildingId { get; init; }

    /// <summary>
    /// Place IDs, separated by commas.
    /// </summary>
    public long[]? PlaceId { get; init; }

    /// <summary>
    /// The IDs of the cities separated by commas.
    /// </summary>
    public long[]? CityId { get; init; }

    /// <summary>
    /// The IDs of the metro stations separated by commas.
    /// </summary>
    public long[]? Subway { get; init; }

    /// <summary>
    /// The coordinates of the upper left vertex of a rectangular area limiting the search results in the lon, lat format.
    /// </summary>
    public string? Point1 { get; init; }

    /// <summary>
    /// The coordinates of the lower right vertex of a rectangular area limiting the search results in the lon, lat format.
    /// </summary>
    public string? Point2 { get; init; }

    /// <summary>
    /// Polygon in WKT format.
    /// </summary>
    public string? Polygon { get; init; }

    /// <summary>
    /// The coordinates of the upper left vertex of a rectangular visibility scope in the lon, lat format.
    /// </summary>
    public string? Viewpoint1 { get; init; }

    /// <summary>
    /// The coordinates of the lower right vertex of a rectangular visibility scope in the lon, lat format.
    /// </summary>
    public string? Viewpoint2 { get; init; }

    /// <summary>
    /// Region identifier.
    /// </summary>
    public int? RegionId { get; init; }

    /// <summary>
    /// The number of the requested page.
    /// </summary>
    public int? Page { get; init; }

    /// <summary>
    /// Number of search results displayed on one page.
    /// </summary>
    public int? PageSize { get; init; }

    /// <summary>
    /// The ID of the category.
    /// </summary>
    public int[]? RubricId { get; init; }

    /// <summary>
    /// Filter by the ID of the organization to which the company belongs.
    /// </summary>
    public long? OrgId { get; init; }

    /// <summary>
    /// Filter by availability of photos.
    /// </summary>
    public bool? HasPhotos { get; init; }

    /// <summary>
    /// Filter by availability of rating on flamp.ru.
    /// </summary>
    public bool? HasRating { get; init; }

    /// <summary>
    /// Filter by availability of reviews on flamp.ru.
    /// </summary>
    public bool? HasReviews { get; init; }

    /// <summary>
    /// Filter by availability of website.
    /// </summary>
    public bool? HasSite { get; init; }

    /// <summary>
    /// Opening hours of the company.
    /// </summary>
    public string? WorkTime { get; init; }

    /// <summary>
    /// Filters companies which have the opening date later than the passed parameter.
    /// </summary>
    public string? OpenedAfterDate { get; init; }

    /// <summary>
    /// Filter by availability of the individual taxpayer identification number.
    /// </summary>
    public bool? HasItin { get; init; }

    /// <summary>
    /// Filter by availability of the trading license.
    /// </summary>
    public bool? HasTradeLicense { get; init; }

    public Dictionary<string, string> ToQueryParameters()
    {
        var parameters = new Dictionary<string, string>
        {
            ["key"] = Key,
        };

        AddString(parameters, "locale", Locale);
        AddString(parameters, "q", Query);
        AddArray(parameters, "type", Type);
        AddArray(parameters, "fields", Fields);
        AddString(parameters, "search_type", SearchType);
        AddBool(parameters, "search_is_query_text_complete", SearchIsQueryTextComplete);
        AddBool(parameters, "search_nearby", SearchNearby);
        AddString(parameters, "search_input_method", SearchInputMethod);
        AddString(parameters, "search_territory_of_interest", SearchTerritoryOfInterest);
        AddString(parameters, "sort", Sort);
        AddString(parameters, "sort_point", SortPoint);
        AddString(parameters, "location", Location);
        AddDouble(parameters, "lon", Lon);
        AddDouble(parameters, "lat", Lat);
        AddString(parameters, "point", Point);
        AddInt(parameters, "radius", Radius);
        AddArray(parameters, "district_id", DistrictId);
        AddArray(parameters, "building_id", BuildingId);
        AddArray(parameters, "place_id", PlaceId);
        AddArray(parameters, "city_id", CityId);
        AddArray(parameters, "subway", Subway);
        AddString(parameters, "point1", Point1);
        AddString(parameters, "point2", Point2);
        AddString(parameters, "polygon", Polygon);
        AddString(parameters, "viewpoint1", Viewpoint1);
        AddString(parameters, "viewpoint2", Viewpoint2);
        AddInt(parameters, "region_id", RegionId);
        AddInt(parameters, "page", Page);
        AddInt(parameters, "page_size", PageSize);
        AddArray(parameters, "rubric_id", RubricId);
        AddLong(parameters, "org_id", OrgId);
        AddBool(parameters, "has_photos", HasPhotos);
        AddBool(parameters, "has_rating", HasRating);
        AddBool(parameters, "has_reviews", HasReviews);
        AddBool(parameters, "has_site", HasSite);
        AddString(parameters, "work_time", WorkTime);
        AddString(parameters, "opened_after_date", OpenedAfterDate);
        AddBool(parameters, "has_itin", HasItin);
        AddBool(parameters, "has_trade_license", HasTradeLicense);

        return parameters;
    }

    private static void AddString(IDictionary<string, string> parameters, string key, string? value)
    {
        if (!string.IsNullOrWhiteSpace(value))
        {
            parameters[key] = value;
        }
    }

    private static void AddBool(IDictionary<string, string> parameters, string key, bool? value)
    {
        if (value.HasValue)
        {
            parameters[key] = value.Value ? "true" : "false";
        }
    }

    private static void AddInt(IDictionary<string, string> parameters, string key, int? value)
    {
        if (value.HasValue)
        {
            parameters[key] = value.Value.ToString(CultureInfo.InvariantCulture);
        }
    }

    private static void AddLong(IDictionary<string, string> parameters, string key, long? value)
    {
        if (value.HasValue)
        {
            parameters[key] = value.Value.ToString(CultureInfo.InvariantCulture);
        }
    }

    private static void AddDouble(IDictionary<string, string> parameters, string key, double? value)
    {
        if (value.HasValue)
        {
            parameters[key] = value.Value.ToString(CultureInfo.InvariantCulture);
        }
    }

    private static void AddArray<T>(IDictionary<string, string> parameters, string key, T[]? values)
    {
        if (values is { Length: > 0 })
        {
            parameters[key] = string.Join(",", values);
        }
    }
}