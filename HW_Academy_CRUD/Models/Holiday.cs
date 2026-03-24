using System;
using System.Collections.Generic;

namespace HW_Academy_CRUD.Models;

public partial class Holiday
{
    public byte HolidayId { get; set; }

    public string HolidayName { get; set; } = null!;

    public byte Duration { get; set; }

    public byte? StartDay { get; set; }

    public byte? StartMonth { get; set; }

    public virtual ICollection<DaysOff> DaysOffs { get; set; } = new List<DaysOff>();
}
