using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Suggest data.
/// </summary>
public class SuggestResult
{
    /// <summary>
    /// Total count.
    /// </summary>
    [JsonProperty("total")]
    public int Total { get; set; }

    /// <summary>
    /// Result items.
    /// </summary>
    [JsonProperty("items", ItemConverterType = typeof(SuggestItemConverter))]
    public List<SuggestItemBase> Items { get; set; }

    /// <summary>
    /// Filters items.
    /// </summary>
    public IEnumerable<SuggestItemBase> GetItemsByType(string type)
    {
        return Items?.Where(item => item.IsType(type))
            ?? Enumerable.Empty<SuggestItemBase>();
    }
}
