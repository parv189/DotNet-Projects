using System;
using System.Collections.Generic;

namespace cars.Models;

public partial class Seller
{
    public int SellerId { get; set; }

    public int? DistributerId { get; set; }

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();

    public virtual Destributer? Distributer { get; set; }
}
