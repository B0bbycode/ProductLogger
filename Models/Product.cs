// Product.cs
using System;

namespace ProductLog.Models
{
public class Product
{
public string Name { get; set; }
public string ImagePath { get; set; }
public string Sku { get; set; }
public string Description { get; set; }
public int Unit { get; set; }
    public Product(string name, string imagePath, string sku, string description, int unit)
    {
        Name = name;
        ImagePath = imagePath;
        Sku = sku;
        Description = description;
        Unit = unit;
    }

    public override string ToString()
    {
        return $"{Name} - {Sku}";
    }
}
}