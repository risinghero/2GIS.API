using System.Collections.Generic;
using System.Globalization;

namespace FT.TwoGis.Api;

/// <summary>
/// Represents a request for suggests.
/// </summary>
/// <param name="Key">The API key for authentication.</param>
public record class SuggestRequest(string Key)
{
    /// <summary>
    /// The locale from which the search is performed and the results are given.
    /// </summary>
    public string? Locale { get; init; }

    /// <summary>
    /// The query string for the suggest request.
    /// </summary>
    public string? Query { get; init; }

    /// <summary>
    /// The types of geo-objects among which the search is performed.
    /// </summary>
    public string[]? Type { get; init; }

    /// <summary>
    /// Additional fields to be displayed in the response.
    /// </summary>
    public string[]? Fields { get; init; }

    /// <summary>
    /// Suggest type.
    /// </summary>
    public string? SuggestType { get; init; }

    /// <summary>
    /// User coordinates in the format lon, lat.
    /// </summary>
    public string? Location { get; init; }

    /// <summary>
    /// The coordinates of the upper left vertex of a rectangular visibility scope in the lon, lat format.
    /// </summary>
    public string? Viewpoint1 { get; init; }

    /// <summary>
    /// The coordinates of the lower right vertex of a rectangular visibility scope in the lon, lat format.
    /// </summary>
    public string? Viewpoint2 { get; init; }

    /// <summary>
    /// Polygon in WKT format.
    /// </summary>
    public string? Polygon { get; init; }

    /// <summary>
    /// Region identifier.
    /// </summary>
    public int? RegionId { get; init; }

    /// <summary>
    /// Number of search results displayed on one page.
    /// </summary>
    public int? PageSize { get; init; }

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
    /// Converts the request to a dictionary of query parameters.
    /// </summary>
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
        AddString(parameters, "suggest_type", SuggestType);
        AddString(parameters, "location", Location);
        AddString(parameters, "viewpoint1", Viewpoint1);
        AddString(parameters, "viewpoint2", Viewpoint2);
        AddString(parameters, "polygon", Polygon);
        AddInt(parameters, "region_id", RegionId);
        AddInt(parameters, "page_size", PageSize);
        AddBool(parameters, "search_is_query_text_complete", SearchIsQueryTextComplete);
        AddBool(parameters, "search_nearby", SearchNearby);
        AddString(parameters, "search_input_method", SearchInputMethod);
        AddString(parameters, "search_territory_of_interest", SearchTerritoryOfInterest);

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
    private static void AddArray<T>(IDictionary<string, string> parameters, string key, T[]? values)
    {
        if (values is { Length: > 0 })
        {
            parameters[key] = string.Join(",", values);
        }
    }
}
