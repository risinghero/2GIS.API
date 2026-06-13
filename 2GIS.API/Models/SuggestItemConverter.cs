using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FT.TwoGis.Api.Models;

internal sealed class SuggestItemConverter : JsonConverter
{
    public override bool CanConvert(Type objectType)
    {
        return objectType == typeof(SuggestItemBase);
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        var item = JObject.Load(reader);
        var targetType = ResolveType(item.Value<string>("type"));
        var target = (SuggestItemBase)Activator.CreateInstance(targetType);

        using var itemReader = item.CreateReader();
        serializer.Populate(itemReader, target);

        return target;
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        serializer.Serialize(writer, value);
    }

    private static Type ResolveType(string type)
    {
        return type switch
        {
            "user_query" => typeof(SuggestUserQueryItem),
            "rubric" => typeof(SuggestRubricItem),
            "metarubric" => typeof(SuggestMetarubricItem),
            "meta_rubric" => typeof(SuggestMetarubricItem),
            "branch" => typeof(SuggestBranchItem),
            "org" => typeof(SuggestOrgItem),
            "adm_div" => typeof(SuggestAdmDivItem),
            "building" => typeof(SuggestBuildingItem),
            "street" => typeof(SuggestStreetItem),
            "attraction" => typeof(SuggestAttractionItem),
            "parking" => typeof(SuggestParkingItem),
            "road" => typeof(SuggestRoadItem),
            "route" => typeof(SuggestRouteItem),
            "station" => typeof(SuggestStationItem),
            _ => typeof(SuggestGenericItem),
        };
    }
}
