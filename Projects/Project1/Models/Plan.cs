using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class Plan
    {
        [Key]
        public int PlanId { get; set; }
        public int PlanDays { get; set; }
        public int PlanAmount { get; set;}
        public int PlanCv { get; set; }
        public int PlanEmails { get;set; }

        public ICollection<Company>? companies { get; set;}
    }
}
