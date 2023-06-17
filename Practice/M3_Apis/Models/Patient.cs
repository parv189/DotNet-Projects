using System;
using System.Collections.Generic;

namespace M3_Apis.Models
{
    public partial class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? DoctId { get; set; }
        public int? DeptId { get; set; }
        public int? HealthId { get; set; }
        public int? DrugId { get; set; }

        public virtual Department? Dept { get; set; }
        public virtual Doctor? Doct { get; set; }
        public virtual Drug? Drug { get; set; }
        public virtual Healthcare? Health { get; set; }
    }
}
