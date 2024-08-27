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
        Published = "Active",
        Price = 20.32M,
        ReleaseAt = new DateOnly(2024,07,3)
    },
    new(){
        Id = 2,
        
        Name = "Test 2",
        Published = "Draft",
        Price = 32.34M,
        ReleaseAt = new DateOnly(2024,07,04)
    },
    new(){
        Id = 3,
       
        Name = "Test 3",
        Published = "Draft",
        Price = 35.64M,
        ReleaseAt = new DateOnly(2024,07,13)
    },
    ];

    private readonly Published[] publishes = new PublishesClient().GetPublishes();
    public ProductTable[] GetProducts() => [..products];

    public void AddProduct(ProductDetails product)
    {
        // if the publishedId is null, always there ahould be a value for publiesed or not
        ArgumentException.ThrowIfNullOrWhiteSpace(product.PublishedId);
        var published = publishes.Single(published => published.Id == int.Parse(product.PublishedId));
        var productTable = new ProductTable
        {
            Id = products.Count +1,
            Name = product.Name,
            Published = published.Name,
            Price = product.Price,
            ReleaseAt = product.ReleaseAt
        };

        products.Add(productTable);
    }
}
