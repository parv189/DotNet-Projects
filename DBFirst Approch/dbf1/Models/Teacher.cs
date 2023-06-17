using System;
using System.Collections.Generic;

namespace dbf1.Models;

public partial class Teacher
{
    public int TeacherId { get; set; }

    public string Name { get; set; } = null!;

    public string SubjectName { get; set; } = null!;

    public virtual Cource? Cource { get; set; }
}
