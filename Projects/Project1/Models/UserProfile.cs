using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class UserProfile
    {
        [Key]
        public int UserProfileId { get; set; }
        public string UserProfileskills { get; set; }
        public int UserId { get; set; }
        public int EducationsscId { get; set; }
        public int EducationhscId { get; set; }
        public int EducationdegreeId { get; set; }
        public int UserLocationId { get; set; }

        
        public Educationhsc? educationhscs { get;set; }
        public Educationssc? educationsscs { get; set; }
        public UserLocation userLocations { get; set; }
        public Educationdegree? educationdegrees { get; set; }
        public ICollection<UserCompanyExperience> userCompanyExperiences { get; set; }
        public ICollection<UserProject> userProjects { get; set; }
        public string UserProfileResume { get; set; }
        public User Users { get; set; }
         
        
    }
}
