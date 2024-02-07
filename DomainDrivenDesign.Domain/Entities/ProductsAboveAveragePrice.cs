using System;
using System.Collections.Generic;

namespace DomainDrivenDesign.Domain.Entities;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
