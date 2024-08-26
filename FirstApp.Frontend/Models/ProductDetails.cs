using System;

namespace FirstApp.Frontend.Models;

public class ProductDetails
{
    public int Id {get; set; }

    public string? Published {get; set; }
    public required string Name {get; set; }

    public decimal Price {get; set; }

    public DateOnly ReleaseAt {get; set; }

}
