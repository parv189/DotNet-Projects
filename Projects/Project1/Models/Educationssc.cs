using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class Educationssc
    {
        [Key]
        public int EducationsscId { get; set; }
        public string EducationsscName { get; set;}
        public string EducationsscUniversityName { get; set;}
        public int EducationsscStartYear { get; set;}
        public int EducationsscEndYear { get; set; }
        public int Educationsscmarks { get; set; }
        public int UserProfileId { get; set; }
        public UserProfile UserProfiles { get; set; }



    }
}
