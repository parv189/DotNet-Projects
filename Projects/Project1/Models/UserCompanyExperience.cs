using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class UserCompanyExperience
    {
        [Key]
        public int UserCompanyExperienceId { get; set; }
        public string UserCompanyExperienceCompanyName { get; set;}
        public string UserCompanyExperienceYear { get;set;}
        public string UserCompanyExperienceMonth { get; set; }
        public string UserCompanyExperiencejobprofile { get;set;}
        public string UserCompanyExperiencedesignation { get; set; }
        public DateTime UserCompanyExperiencejoiningDate { get;set;}
    }
}
