using System;
using FirstApp.Frontend.Models;

namespace FirstApp.Frontend.Clients;

public class ProductsClient
{
    private readonly List<ProductTable> products = 
    [
    new(){
        Id = 1,
        Name = "Test 1",
        Published = "image",
        Price = 20.32M,
        ReleaseAt = new DateOnly(2024,07,3)
    },
    new(){
        Id = 2,
        
        Name = "Test 2",
        Published = "image",
        Price = 32.34M,
        ReleaseAt = new DateOnly(2024,07,04)
    },
    new(){
        Id = 3,
       
        Name = "Test 3",
        Published = "image",
        Price = 35.64M,
        ReleaseAt = new DateOnly(2024,07,13)
    },
    ];
    public ProductTable[] GetProducts() => [..products];
}
