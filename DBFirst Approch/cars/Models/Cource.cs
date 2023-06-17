using System;
using System.Collections.Generic;

namespace cars.Models;

public partial class Cource
{
    public int CourceId { get; set; }

    public string? CourceName { get; set; }

    public DateTime? StartDate { get; set; }

    public virtual Teacher CourceNavigation { get; set; } = null!;
}
