using System;
using System.Collections.Generic;

namespace cars.Models;

public partial class Car
{
    public int CarId { get; set; }

    public string? ModelName { get; set; }

    public int? SellerId { get; set; }

    public virtual Seller? Seller { get; set; }
}
