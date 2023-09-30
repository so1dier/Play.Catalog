using System;
namespace Play.Catalog.Service.Entities;

public class Item
{
    public Guid id {get; set;}
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
}
