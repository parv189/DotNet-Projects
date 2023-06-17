using System;
using System.Collections.Generic;

namespace Assignment2.Models;

public partial class Multimedicine
{
    public int MultimedicineId { get; set; }

    public int? TreatmentScheduleId { get; set; }

    public int? DrugsId { get; set; }

    public string? MultimedicineEattime { get; set; }

    public virtual Drug? Drugs { get; set; }

    public virtual TreatmentSchedule? TreatmentSchedule { get; set; }
}
