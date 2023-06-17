using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class Educationhsc
    {
        [Key]
        public int EducationhscId { get; set; }
        public string EducationhscName { get; set; }
        public string EducationhscUniversityName { get; set; }
        public int EducationhscStartYear { get; set; }
        public int EducationhscEndYear { get; set; }
        public int Educationhscmarks { get; set; }
        public int UserProfileId { get; set; }
        public UserProfile UserProfiles { get; set; }
    }
}
