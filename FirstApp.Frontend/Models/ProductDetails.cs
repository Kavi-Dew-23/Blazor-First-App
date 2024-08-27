using System;
using System.ComponentModel.DataAnnotations;

namespace FirstApp.Frontend.Models;

public class ProductDetails
{
    public int Id {get; set; }

    [Required]
    [StringLength(50)]
    public required string Name {get; set; }

    [Required(ErrorMessage = "State is required.")]
     public string? PublishedId {get; set; }

    
    [Range(1.01,double.MaxValue,ErrorMessage ="Price is Required")]
    public decimal Price {get; set; }

    public DateOnly ReleaseAt {get; set; }

}
