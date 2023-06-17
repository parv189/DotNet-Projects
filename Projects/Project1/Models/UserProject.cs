using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class UserProject
    {
        [Key]
        public int UserProjectId { get; set; }
        public string UserProjectName { get; set; }
        public int UserProjectRole { get; set; }
        public string UserProjectRoleDescription { get; set;}
        public string UserProjectSkills { get;set; }
    }
}
