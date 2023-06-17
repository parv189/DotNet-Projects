using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class Role
    {
        [Key]   
        public int Roleid { get; set; }
        public string RoleName { get; set; }

        public ICollection<User> users { get; set;}
    }
}
