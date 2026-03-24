using System;
using System.Collections.Generic;

namespace Academy.Models;

public partial class Holiday
{
    public short HolidayId { get; set; }

    public string HolidayName { get; set; } = null!;

    public short Duration { get; set; }

    public short? StartDay { get; set; }

    public short? StartMonth { get; set; }

    public virtual ICollection<DaysOff> DaysOffs { get; set; } = new List<DaysOff>();
}
