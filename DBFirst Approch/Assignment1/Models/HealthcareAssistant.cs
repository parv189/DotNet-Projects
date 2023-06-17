using System;
using System.Collections.Generic;

namespace Assignment2.Models;

public partial class HealthcareAssistant
{
    public int HealthcareAssistantsId { get; set; }

    public string? HealthcareAssistantsName { get; set; }

    public int? DepartmentId { get; set; }

    public int? PatientId { get; set; }

    public virtual Department? Department { get; set; }

    public virtual Patient? Patient { get; set; }
}
