using System;
using System.Collections.Generic;

namespace HW_Academy_CRUD.Models;

public partial class DaysOff
{
    public short DayoffId { get; set; }

    public DateOnly Date { get; set; }

    public byte Holiday { get; set; }

    public virtual Holiday HolidayNavigation { get; set; } = null!;
}
