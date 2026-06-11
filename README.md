# FT.TwoGis.Api

A small .NET client for the 2GIS Geocoder API.

## Features

- Typed geocoding request model
- Query parameter serialization via `GeocodeRequest.ToQueryParameters()`
- Async HTTP client for `/3.0/items/geocode`
- JSON deserialization with `Newtonsoft.Json`
- Test project with unit and optional live integration tests

## Project structure

- `2GIS.API` - main library
- `2GIS.API.Tests` - tests

## Target frameworks

Library:
- `.NET Standard 2.0`
- `.NET Standard 2.1`

Tests:
- `.NET 9`

## Installation

Clone the repository:

```powershell
git clone https://github.com/risinghero/2GIS.API.git
cd 2GIS.API.Geocoder
```

Add a project reference from your application:

```xml
<ItemGroup>
  <ProjectReference Include="..\2GIS.API\2GIS.API.csproj" />
</ItemGroup>
```

## Usage

```csharp
using FT.TwoGis.Api;

var client = new GeocoderClient();

var response = await client.SearchAsync(new GeocodeRequest("your-api-key")
{
	Query = "Novosibirsk",
	Locale = "en_RU",
	PageSize = 5,
	Fields = ["items.point", "items.address"]
});

foreach (var item in response.Result.Items)
{
	Console.WriteLine(item.Name);
}
```

## Example request parameters

`GeocodeRequest` supports common geocoder parameters, including:

- `Locale`
- `Query`
- `Type`
- `Fields`
- `SearchType`
- `SearchNearby`
- `Location`
- `Point`
- `Radius`
- `RegionId`
- `Page`
- `PageSize`
- `RubricId`

See the 2GIS Geocoder API documentation for the full parameter reference:
- https://docs.2gis.com/en/api/search/geocoder/reference/3.0/items/geocode

## Running tests

Run all tests in the test project:

```powershell
dotnet test .\2GIS.API.Tests\2GIS.API.Tests.csproj
```

## User secrets for live API tests

The test project supports optional live integration tests using a 2GIS API key from user secrets.

Initialize or set the secret:

```powershell
dotnet user-secrets set "2GIS:ApiKey" "your_api_key" --project .\2GIS.API.Tests\2GIS.API.Tests.csproj
```

If the secret is not configured, the live test exits without making a real API call.

## Build

Build the library:

```powershell
dotnet build .\2GIS.API\2GIS.API.csproj
```

## Notes

- The repository currently does not require a solution file to build or test.
- `HttpClient` can be injected into `GeocoderClient` for custom configuration or testing.
- API keys should not be committed to source control.

## License

This project is licensed under the MIT License.

See [LICENSE.txt](LICENSE.txt) for details.
