using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FT.TwoGis.Api.Models;
using Newtonsoft.Json;

namespace FT.TwoGis.Api;

public class GeocoderClient(HttpClient? httpClient = null)
{
    private const string GeocodeUrl = "https://catalog.api.2gis.com/3.0/items/geocode";
    private const string SuggestUrl = "https://catalog.api.2gis.com/3.0/suggests";
    private readonly HttpClient _httpClient = httpClient ?? DefaultClient;
    private static readonly HttpClient DefaultClient = new();

    public async Task<ItemsResponse> SearchAsync(GeocodeRequest request)
    {
        if (request is null)
        {
            throw new ArgumentNullException(nameof(request));
        }

        return await SendAsync<ItemsResponse>(GeocodeUrl, request.ToQueryParameters());
    }

    public async Task<SuggestResponse> SuggestAsync(SuggestRequest request)
    {
        if (request is null)
        {
            throw new ArgumentNullException(nameof(request));
        }

        return await SendAsync<SuggestResponse>(SuggestUrl, request.ToQueryParameters());
    }

    private async Task<TResponse> SendAsync<TResponse>(string baseUrl, System.Collections.Generic.IReadOnlyDictionary<string, string> parameters)
    {
        var queryString = string.Join("&", parameters
            .Select(parameter => $"{Uri.EscapeDataString(parameter.Key)}={Uri.EscapeDataString(parameter.Value)}"));

        var url = string.IsNullOrEmpty(queryString)
            ? baseUrl
            : $"{baseUrl}?{queryString}";

        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<TResponse>(content);
    }
}
