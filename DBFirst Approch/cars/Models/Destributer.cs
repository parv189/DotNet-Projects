using System;
using System.Collections.Generic;

namespace cars.Models;

public partial class Destributer
{
    public int DestributerId { get; set; }

    public string? CompenyName { get; set; }

    public int? CarId { get; set; }

    public int? TransportId { get; set; }

    public int? BillNo { get; set; }

    public virtual ICollection<Seller> Sellers { get; set; } = new List<Seller>();
}
