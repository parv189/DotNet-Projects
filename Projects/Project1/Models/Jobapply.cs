using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class Jobapply
    {
        [Key]
        public int JobapplyId { get; set; }

        public int JobId { get; set; }

        public int UserId { get; set; }
        public User Users { get; set; }

        public Job Jobs { get; set; }

    }
}
