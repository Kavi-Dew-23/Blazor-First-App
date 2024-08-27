using System;

namespace FirstApp.Frontend.Models;

public class ProductDetails
{
    public int Id {get; set; }

   
    public required string Name {get; set; }
     public string? PublishedId {get; set; }

    public decimal Price {get; set; }

    public DateOnly ReleaseAt {get; set; }

}
