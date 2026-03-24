using System;
using System.Collections.Generic;

namespace HW_Academy_CRUD.Models;

public partial class Schedule
{
    public long LessonId { get; set; }

    public int Group { get; set; }

    public short Discipline { get; set; }

    public short Teacher { get; set; }

    public DateOnly? Date { get; set; }

    public TimeOnly? Time { get; set; }

    public bool? Spent { get; set; }

    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    public virtual Discipline DisciplineNavigation { get; set; } = null!;

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();

    public virtual Group GroupNavigation { get; set; } = null!;

    public virtual Teacher TeacherNavigation { get; set; } = null!;
}
