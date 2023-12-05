using System;
using System.Collections.Generic;

namespace TrangWeb5.Models.Entities;

public partial class Product
{
    public int Id { get; set; }

    public string? ProductName { get; set; }

    public string? Quantity { get; set; }

    public string? Price { get; set; }
}
