using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Project1.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyDescription { get; set; }
        public int? PlanId { get; set; }

        [JsonIgnore]
        public ICollection<Job>? jobs { get; set; }
        [JsonIgnore]
        public Plan? Plans { get; set; }
        public int? CompanyCreateId { get; set; }
        public DateTime? CompanyCreateDate { get; set; }
        public int? CompanyModifyId { get; set; }
        public DateTime? CompanymodifyDate { get; set; }

/*        public User? Users1 { get; set; }
        public User? Users2 { get; set; }*/

    }
}
