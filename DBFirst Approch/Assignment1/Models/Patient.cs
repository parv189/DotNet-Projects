using System;
using System.Collections.Generic;

namespace Assignment2.Models;

public partial class Patient
{
    public int PatientId { get; set; }

    public string? PatientName { get; set; }

    public string? PatientGender { get; set; }

    public virtual ICollection<HealthcareAssistant> HealthcareAssistants { get; set; } = new List<HealthcareAssistant>();

    public virtual ICollection<TreatmentSchedule> TreatmentSchedules { get; set; } = new List<TreatmentSchedule>();
}
