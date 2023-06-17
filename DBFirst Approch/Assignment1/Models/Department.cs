using System;
using System.Collections.Generic;

namespace Assignment2.Models;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string? DepartmentName { get; set; }

    public virtual ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();

    public virtual ICollection<HealthcareAssistant> HealthcareAssistants { get; set; } = new List<HealthcareAssistant>();
}
