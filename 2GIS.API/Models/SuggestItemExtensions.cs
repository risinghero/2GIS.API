using System;
using Newtonsoft.Json.Linq;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Suggest helpers.
/// </summary>
public static class SuggestItemExtensions
{
    /// <summary>
    /// Gets item type.
    /// </summary>
    public static string GetItemType(this SuggestItemBase item)
    {
        return item?.Type;
    }

    /// <summary>
    /// Checks item type.
    /// </summary>
    public static bool IsType(this SuggestItemBase item, string type)
    {
        return string.Equals(item?.Type, type, StringComparison.OrdinalIgnoreCase);
    }

    /// <summary>
    /// Gets string field.
    /// </summary>
    public static string GetString(this SuggestItemBase item, string propertyName)
    {
        var token = GetToken(item, propertyName);
        return token?.Type == JTokenType.Null ? null : token?.Value<string>();
    }

    /// <summary>
    /// Gets field value.
    /// </summary>
    public static T GetValueOrDefault<T>(this SuggestItemBase item, string propertyName)
    {
        var token = GetToken(item, propertyName);
        if (token is null || token.Type == JTokenType.Null)
        {
            return default;
        }

        return token.ToObject<T>();
    }

    private static JToken GetToken(SuggestItemBase item, string propertyName)
    {
        if (item is null)
        {
            return null;
        }

        var token = JObject.FromObject(item)[propertyName];
        return token ?? (item.AdditionalData.TryGetValue(propertyName, out var value) ? value : null);
    }
}
