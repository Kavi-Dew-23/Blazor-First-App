using System;
using FirstApp.Frontend.Models;

namespace FirstApp.Frontend.Clients;

public class PublishesClient
{
    private readonly Published[] publishes = 
    [
        new()
        {
            Id = 1,
            Name = "Active"
        },
        new()
        {
            Id = 1,
            Name = "Draft"
        },

    ];

    public Published[] GetPublishes() => publishes;
}
