using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class User
    {

        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public string UserMobile { get; set; }
        public int? UserCreateId { get; set; }
        public DateTime? UserCreateDate { get; set; }
        public int? UserModifyId { get; set; }
        public DateTime? UsermodifyDate { get; set; }

        public int RoleId { get; set; }
        public ICollection<Jobapply> jobapplies { get; set; }

       /* public Company? companies1 { get; set; }
        public Company? companies2 { get; set; }

        public Job? Job1 { get; set; }
        public Job? Job2 { get; set; }
        public User? Users1 { get; set; }
        public User? Users2 { get; set; }*/
        public Role Roles { get; set; }
        public UserProfile UserProfiles { get; set; }
    }
}
