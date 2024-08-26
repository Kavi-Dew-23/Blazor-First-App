using System;

namespace FirstApp.Frontend.Models;

public class ProductTable
{
    public int Id {get; set; }

    public string Image {get; set; }
    public required string Name {get; set; }

    public decimal Price {get; set; }

    public DateOnly ReleaseAt {get; set; }

}
