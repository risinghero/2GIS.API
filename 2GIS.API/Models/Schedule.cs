using System.Collections.Generic;
using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

/// <summary>
/// Object schedule.
/// </summary>
public class Schedule
{
    /// <summary>
    /// Schedule comment.
    /// </summary>
    [JsonProperty("comment")]
    public string Comment { get; set; }

    /// <summary>
    /// Open all day.
    /// </summary>
    [JsonProperty("is_24x7")]
    public bool Is24x7 { get; set; }

    /// <summary>
    /// Monday schedule.
    /// </summary>
    [JsonProperty("Mon")]
    public DaySchedule Mon { get; set; }

    /// <summary>
    /// Tuesday schedule.
    /// </summary>
    [JsonProperty("Tue")]
    public DaySchedule Tue { get; set; }

    /// <summary>
    /// Wednesday schedule.
    /// </summary>
    [JsonProperty("Wed")]
    public DaySchedule Wed { get; set; }

    /// <summary>
    /// Thursday schedule.
    /// </summary>
    [JsonProperty("Thu")]
    public DaySchedule Thu { get; set; }

    /// <summary>
    /// Friday schedule.
    /// </summary>
    [JsonProperty("Fri")]
    public DaySchedule Fri { get; set; }

    /// <summary>
    /// Saturday schedule.
    /// </summary>
    [JsonProperty("Sat")]
    public DaySchedule Sat { get; set; }

    /// <summary>
    /// Sunday schedule.
    /// </summary>
    [JsonProperty("Sun")]
    public DaySchedule Sun { get; set; }
}

/// <summary>
/// Day schedule.
/// </summary>
public class DaySchedule
{
    /// <summary>
    /// Working hours.
    /// </summary>
    [JsonProperty("working_hours")]
    public List<WorkingHours> WorkingHours { get; set; }
}

/// <summary>
/// Time range.
/// </summary>
public class WorkingHours
{
    /// <summary>
    /// Start time.
    /// </summary>
    [JsonProperty("from")]
    public string From { get; set; }

    /// <summary>
    /// End time.
    /// </summary>
    [JsonProperty("to")]
    public string To { get; set; }
}
