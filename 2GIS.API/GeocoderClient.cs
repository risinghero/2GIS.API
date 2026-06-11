using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FT.TwoGis.Api.Models;
using Newtonsoft.Json;

namespace FT.TwoGis.Api;

public class GeocoderClient(HttpClient? httpClient = null)
{
    private const string BaseUrl = "https://catalog.api.2gis.com/3.0/items/geocode";
    private readonly HttpClient _httpClient = httpClient ?? DefaultClient;
    private static readonly HttpClient DefaultClient = new();

    public async Task<ItemsResponse> SearchAsync(GeocodeRequest request)
    {
        if (request is null)
        {
            throw new ArgumentNullException(nameof(request));
        }

        var queryString = string.Join("&", request
            .ToQueryParameters()
            .Select(parameter => $"{Uri.EscapeDataString(parameter.Key)}={Uri.EscapeDataString(parameter.Value)}"));

        var url = string.IsNullOrEmpty(queryString)
            ? BaseUrl
            : $"{BaseUrl}?{queryString}";

        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<ItemsResponse>(content);
    }
}
