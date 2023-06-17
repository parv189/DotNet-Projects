using System;
using System.Collections.Generic;

namespace Assignment2.Models;

public partial class Doctor
{
    public int DoctorId { get; set; }

    public string? DoctorName { get; set; }

    public string? DoctorGender { get; set; }

    public int? DepartmentId { get; set; }

    public virtual Department? Department { get; set; }

    public virtual ICollection<TreatmentSchedule> TreatmentSchedules { get; set; } = new List<TreatmentSchedule>();
}
