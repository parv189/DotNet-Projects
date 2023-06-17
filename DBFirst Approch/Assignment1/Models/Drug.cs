using System;
using System.Collections.Generic;

namespace Assignment2.Models;

public partial class Drug
{
    public int DrugsId { get; set; }

    public string? DrugsName { get; set; }

    public virtual ICollection<Multimedicine> Multimedicines { get; set; } = new List<Multimedicine>();
}
