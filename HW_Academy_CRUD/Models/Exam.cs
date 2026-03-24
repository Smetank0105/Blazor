using System;
using System.Collections.Generic;

namespace HW_Academy_CRUD.Models;

public partial class Exam
{
    public int Student { get; set; }

    public short Discipline { get; set; }

    public DateOnly? Date { get; set; }

    public byte? Grade { get; set; }

    public virtual Discipline DisciplineNavigation { get; set; } = null!;

    public virtual Student StudentNavigation { get; set; } = null!;
}
