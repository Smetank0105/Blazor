using System;
using System.Collections.Generic;

namespace Academy.Models;

public partial class DaysOff
{
    public short DayoffId { get; set; }

    public DateOnly Date { get; set; }

    public short Holiday { get; set; }

    public virtual Holiday HolidayNavigation { get; set; } = null!;
}
