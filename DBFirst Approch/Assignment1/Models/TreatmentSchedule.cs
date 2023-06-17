using System;
using System.Collections.Generic;

namespace Assignment2.Models;

public partial class TreatmentSchedule
{
    public int TreatmentScheduleId { get; set; }

    public int? PatientId { get; set; }

    public int? DoctorId { get; set; }

    public virtual Doctor? Doctor { get; set; }

    public virtual ICollection<Multimedicine> Multimedicines { get; set; } = new List<Multimedicine>();

    public virtual Patient? Patient { get; set; }
}
