using System.Collections.Generic;
using Newtonsoft.Json;

namespace FT.TwoGis.Api.Models;

public class Schedule
{
    [JsonProperty("comment")]
    public string Comment { get; set; }

    [JsonProperty("is_24x7")]
    public bool Is24x7 { get; set; }

    [JsonProperty("Mon")]
    public DaySchedule Mon { get; set; }

    [JsonProperty("Tue")]
    public DaySchedule Tue { get; set; }

    [JsonProperty("Wed")]
    public DaySchedule Wed { get; set; }

    [JsonProperty("Thu")]
    public DaySchedule Thu { get; set; }

    [JsonProperty("Fri")]
    public DaySchedule Fri { get; set; }

    [JsonProperty("Sat")]
    public DaySchedule Sat { get; set; }

    [JsonProperty("Sun")]
    public DaySchedule Sun { get; set; }
}

public class DaySchedule
{
    [JsonProperty("working_hours")]
    public List<WorkingHours> WorkingHours { get; set; }
}

public class WorkingHours
{
    [JsonProperty("from")]
    public string From { get; set; }

    [JsonProperty("to")]
    public string To { get; set; }
}
