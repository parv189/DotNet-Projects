using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }
        public string JobDesignation { get; set; }
        public int JobVacany { get; set; }
        public string JobDetail { get; set; }
        public string JobDescription { get; set; }
        public string JobHrName { get; set; }
        public string JobContactNumber { get; set; }
        public Boolean JobStatus { get; set; }
        public int? JobCreateId { get; set; }
        public DateTime? JobCreateDate { get; set; }
        public int? JobModifyId { get; set; }
        public DateTime? JobmodifyDate { get; set; }
        public ICollection<Jobapply> jobapplies { get; set; }
        public Company Company { get; set; }

    

        /*public User? Users1 { get; set; }
        public User? Users2 { get; set; }*/
    }
}
