using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class UserLocation
    {
        [Key]
        public int UserLocationId { get; set; }
        public string UserLocationCityName { get; set; }
        public string UserLocationStateName { get; set; }
        public string UserLocationCountryName { get; set; }
        public int UserProfileId { get; set; }
        public UserProfile UserProfiles { get; set; }

    }
}
