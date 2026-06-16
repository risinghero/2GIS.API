using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using FT.TwoGis.Api.Models;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace FT.TwoGis.Api.Tests;

public class GeocoderClientSuggestTests
{
    [Fact]
    public async Task SuggestAsync_BuildsExpectedQueryString_AndDeserializesResponse()
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
                    "id": "4504127902577560",
                    "type": "rubric",
                    "name": "Coffee shops",
                    "caption": "Coffee shops",
                    "search_query": "coffee",
                    "suggest_icon": "cafe"
                  }
                ]
              }
            }
            """)
        });

        using var httpClient = new HttpClient(handler);
        var client = new GeocoderClient(httpClient);

        var request = new SuggestRequest("test-api-key")
        {
            Query = "coffee",
            Locale = "ru_RU",
            Fields = ["items.point", "items.address"],
            Type = ["rubric", "branch"],
            SuggestType = "object",
            RegionId = 1,
            Location = "82.921663,55.030195",
            Viewpoint1 = "82.900000,55.040000",
            Viewpoint2 = "82.950000,55.010000",
            Polygon = "POLYGON((82.91 55.06,82.90 55.05,82.92 55.05,82.91 55.06))",
            PageSize = 5,
        };

        var response = await client.SuggestAsync(request);

        Assert.NotNull(handler.RequestUri);
        Assert.Equal("https", handler.RequestUri!.Scheme);
        Assert.Equal("catalog.api.2gis.com", handler.RequestUri.Host);
        Assert.Equal("/3.0/suggests", handler.RequestUri.AbsolutePath);

        var query = ParseQuery(handler.RequestUri.Query);
        Assert.Equal("test-api-key", query["key"]);
        Assert.Equal("coffee", query["q"]);
        Assert.Equal("ru_RU", query["locale"]);
        Assert.Equal("items.point,items.address", query["fields"]);
        Assert.Equal("rubric,branch", query["type"]);
        Assert.Equal("object", query["suggest_type"]);
        Assert.Equal("1", query["region_id"]);
        Assert.Equal("82.921663,55.030195", query["location"]);
        Assert.Equal("82.900000,55.040000", query["viewpoint1"]);
        Assert.Equal("82.950000,55.010000", query["viewpoint2"]);
        Assert.Equal("POLYGON((82.91 55.06,82.90 55.05,82.92 55.05,82.91 55.06))", query["polygon"]);
        Assert.Equal("5", query["page_size"]);

        Assert.NotNull(response);
        Assert.NotNull(response.Meta);
        Assert.Equal(200, response.Meta.Code);
        Assert.NotNull(response.Result);
        Assert.Equal(1, response.Result.Total);
        Assert.Single(response.Result.Items);
        var item = Assert.IsType<SuggestRubricItem>(response.Result.Items[0]);
        Assert.Equal("4504127902577560", item.Id);
        Assert.Equal("rubric", item.GetItemType());
        Assert.Equal("coffee", item.SearchQuery);
        Assert.Equal("cafe", item.SuggestIcon);
        Assert.Single(response.Result.GetItemsByType("rubric"));
    }

    [Fact]
    public async Task SuggestAsync_DeserializesAdditionalTypedSuggestItems()
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
                "total": 3,
                "items": [
                  {
                    "id": "1",
                    "type": "branch",
                    "name": "Branch item",
                    "caption": "Branch item",
                    "region_id": "10",
                    "segment_id": "20",
                    "address_name": "Main st, 1",
                    "full_address_name": "City, Main st, 1",
                    "timezone_offset": 420,
                    "is_routing_available": true
                  },
                  {
                    "id": "2",
                    "type": "building",
                    "name": "Building item",
                    "caption": "Building item",
                    "region_id": "11",
                    "segment_id": "21",
                    "address": {
                      "building_id": "4504235282779074",
                      "components": [
                        {
                          "number": "1",
                          "street": "улица Лермонтова",
                          "street_id": "4504338361765210",
                          "type": "street_number"
                        }
                      ],
                      "postcode": "108816"
                    },
                    "adm_div": [
                      {
                        "id": "1",
                        "name": "Россия",
                        "type": "country"
                      }
                    ],
                    "purpose_name": "Business center",
                    "full_name": "Building item full",
                    "building_name": "Sun Tower",
                    "address_name": "Central ave, 7",
                    "point": {
                      "lat": 55.650394,
                      "lon": 37.323588
                    },
                    "search_attributes": {
                      "handling_type": 0,
                      "suggest_parts": [
                        {
                          "is_suggested": false,
                          "text": "Лермонтова, 1"
                        }
                      ],
                      "suggested_text": "Лермонтова, 1"
                    }
                  },
                  {
                    "id": "3",
                    "type": "station",
                    "name": "Station item",
                    "caption": "Station item",
                    "region_id": "12",
                    "segment_id": "22",
                    "subtype": "metro",
                    "route_logo": "metro-icon",
                    "timezone_offset": 420,
                    "is_routing_available": false
                  }
                ]
              }
            }
            """)
        });

        using var httpClient = new HttpClient(handler);
        var client = new GeocoderClient(httpClient);

        var response = await client.SuggestAsync(new SuggestRequest("test-api-key")
        {
            Query = "test",
            RegionId = 1,
        });

        Assert.Collection(
            response.Result.Items,
            item =>
            {
                var branch = Assert.IsType<SuggestBranchItem>(item);
                Assert.Equal("10", branch.RegionId);
                Assert.Equal("20", branch.SegmentId);
                Assert.Equal("Main st, 1", branch.AddressName);
                Assert.Equal("City, Main st, 1", branch.FullAddressName);
                Assert.Equal(420, branch.TimezoneOffset);
                Assert.True(branch.IsRoutingAvailable);
            },
            item =>
            {
                var building = Assert.IsType<SuggestBuildingItem>(item);
                Assert.Equal("11", building.RegionId);
                Assert.Equal("21", building.SegmentId);
                Assert.Equal("Business center", building.PurposeName);
                Assert.Equal("Building item full", building.FullName);
                Assert.Equal("Sun Tower", building.BuildingName);
                Assert.Equal("Central ave, 7", building.AddressName);
                Assert.NotNull(building.Address);
                Assert.Equal("4504235282779074", building.Address.BuildingId);
                Assert.Single(building.Address.Components);
                Assert.Equal("улица Лермонтова", building.Address.Components[0].Street);
                Assert.NotNull(building.AdmDiv);
                Assert.Single(building.AdmDiv);
                Assert.Equal("Россия", building.AdmDiv[0].Name);
                Assert.NotNull(building.Point);
                Assert.Equal(55.650394, building.Point.Lat);
                Assert.Equal(37.323588, building.Point.Lon);
                Assert.NotNull(building.SearchAttributes);
                Assert.Equal(0, building.SearchAttributes.HandlingType);
                Assert.Single(building.SearchAttributes.SuggestParts);
                Assert.False(building.SearchAttributes.SuggestParts[0].IsSuggested);
                Assert.Equal("Лермонтова, 1", building.SearchAttributes.SuggestParts[0].Text);
                Assert.Equal("Лермонтова, 1", building.SearchAttributes.SuggestedText);
            },
            item =>
            {
                var station = Assert.IsType<SuggestStationItem>(item);
                Assert.Equal("12", station.RegionId);
                Assert.Equal("22", station.SegmentId);
                Assert.Equal("metro", station.Subtype);
                Assert.Equal("metro-icon", station.RouteLogo);
                Assert.Equal(420, station.TimezoneOffset);
                Assert.False(station.IsRoutingAvailable);
            });
    }

    [Fact]
    public async Task SuggestAsync_WithoutApiKeySecret_SkipsIntegrationCall()
    {
        var apiKey = LoadApiKeyFromSecrets();
        if (string.IsNullOrWhiteSpace(apiKey))
        {
            return;
        }

        using var httpClient = new HttpClient();
        var client = new GeocoderClient(httpClient);

        var response = await client.SuggestAsync(new SuggestRequest(apiKey)
        {
            Query = "Новосибирск",
            RegionId = 1,
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
            .AddUserSecrets<GeocoderClientSuggestTests>(optional: true)
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
