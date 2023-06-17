using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class Educationdegree
    {
        [Key]
        public int EducationdegreeId { get; set; }
        public string EducationdegreeName { get; set; }
        public string EducationdegreeUniversityName { get; set; }
        public int EducationdegreeStartYear { get; set; }
        public int EducationdegreeEndYear { get; set; }
        public int Educationdegreemarks { get; set; }
        public int UserProfileId { get; set; }
        public UserProfile UserProfiles { get; set; }

    }
}
