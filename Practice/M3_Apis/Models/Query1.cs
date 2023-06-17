using Microsoft.EntityFrameworkCore;

namespace M3_Apis.Models
{
    [Keyless]
    public class Query1
    {
        public int id { get; set; }
        public string name { get; set; }
        public string MedicineName { get; set; }
    }
}
