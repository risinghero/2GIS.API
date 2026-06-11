using System.Net;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace FT.TwoGis.Api.Tests;

public class GeocoderClientTests
{
    [Fact]
    public async Task SearchAsync_BuildsExpectedQueryString_AndDeserializesResponse()
    {
        var handler = new CapturingHandler(_ => new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new StringContent("""
            {
              "meta": {
                "api_version": "3.0",
                "code": 200,
                "issue_date": "2026-01-01T00:00:00Z"
              },
              "result": {
                "total": 1,
                "items": [
                  {
                    "id": "test-id",
                    "type": "building",
                    "name": "Test building"
                  }
                ]
              }
            }
            """)
        });

        using var httpClient = new HttpClient(handler);
        var client = new GeocoderClient(httpClient);

        var request = new GeocodeRequest("test-api-key")
        {
            Query = "coffee shop",
            Locale = "ru_RU",
            Fields = ["items.point", "items.address"],
            Type = ["building", "street"],
            Page = 2,
            HasSite = true,
        };

        var response = await client.SearchAsync(request);

        Assert.NotNull(handler.RequestUri);
        Assert.Equal("https", handler.RequestUri!.Scheme);
        Assert.Equal("catalog.api.2gis.com", handler.RequestUri.Host);
        Assert.Equal("/3.0/items/geocode", handler.RequestUri.AbsolutePath);

        var query = ParseQuery(handler.RequestUri.Query);
        Assert.Equal("test-api-key", query["key"]);
        Assert.Equal("coffee shop", query["q"]);
        Assert.Equal("ru_RU", query["locale"]);
        Assert.Equal("items.point,items.address", query["fields"]);
        Assert.Equal("building,street", query["type"]);
        Assert.Equal("2", query["page"]);
        Assert.Equal("true", query["has_site"]);

        Assert.NotNull(response);
        Assert.NotNull(response.Meta);
        Assert.Equal(200, response.Meta.Code);
        Assert.NotNull(response.Result);
        Assert.Equal(1, response.Result.Total);
        Assert.Single(response.Result.Items);
        Assert.Equal("test-id", response.Result.Items[0].Id);
    }

    [Fact]
    public async Task SearchAsync_WithoutApiKeySecret_SkipsIntegrationCall()
    {
        var apiKey = LoadApiKeyFromSecrets();
        if (string.IsNullOrWhiteSpace(apiKey))
        {
            return;
        }

        using var httpClient = new HttpClient();
        var client = new GeocoderClient(httpClient);

        var response = await client.SearchAsync(new GeocodeRequest(apiKey)
        {
            Query = "Новосибирск",
            PageSize = 1,
        });

        Assert.NotNull(response);
        Assert.NotNull(response.Result);
        Assert.NotNull(response.Result.Items);
        Assert.NotEmpty(response.Result.Items);
    }

    private static string? LoadApiKeyFromSecrets()
    {
        var configuration = new ConfigurationBuilder()
            .AddUserSecrets<GeocoderClientTests>(optional: true)
            .Build();

        return configuration["2GIS:ApiKey"];
    }

    private static Dictionary<string, string> ParseQuery(string queryString)
    {
        var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        var trimmed = queryString.TrimStart('?');
        if (string.IsNullOrEmpty(trimmed))
        {
            return result;
        }

        foreach (var pair in trimmed.Split('&', StringSplitOptions.RemoveEmptyEntries))
        {
            var separatorIndex = pair.IndexOf('=');
            var key = separatorIndex >= 0 ? pair[..separatorIndex] : pair;
            var value = separatorIndex >= 0 ? pair[(separatorIndex + 1)..] : string.Empty;
            result[Uri.UnescapeDataString(key)] = Uri.UnescapeDataString(value);
        }

        return result;
    }

    private sealed class CapturingHandler(Func<HttpRequestMessage, HttpResponseMessage> responseFactory) : HttpMessageHandler
    {
        private readonly Func<HttpRequestMessage, HttpResponseMessage> _responseFactory = responseFactory;

        public Uri? RequestUri { get; private set; }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            RequestUri = request.RequestUri;
            return Task.FromResult(_responseFactory(request));
        }
    }
}