using Microsoft.EntityFrameworkCore;

namespace Assignment2.Models
{
    [Keyless]
    public class patientreport
    {
        public int PatientId { get; set; }

        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public string DrugsName { get; set; }
        public string MultimedicineEattime { get; set; }

        public string DepartmentName { get; set; }
    }
}
