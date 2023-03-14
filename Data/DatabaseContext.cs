// DatabaseContext.cs
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using ProductLog.Models;

namespace ProductLog.Data
{
public class DatabaseContext
{
private string _filePath; 
    public DatabaseContext(string filePath)
    {
        _filePath = filePath;
        if (!File.Exists(filePath))
        {
            File.Create(filePath).Close();
            SaveData(new List<Product>());
        }
    }

    public List<Product> GetAllProducts()
    {
        string jsonData = File.ReadAllText(_filePath);
        List<Product> products = JsonSerializer.Deserialize<List<Product>>(jsonData);
        return products;
    }

    public void AddProduct(Product product)
    {
        List<Product> products = GetAllProducts();
        products.Add(product);
        SaveData(products);
    }

    public List<Product> SearchProductByName(string name)
    {
        List<Product> products = GetAllProducts();
        List<Product> matchingProducts = new List<Product>();
        foreach (Product product in products)
        {
            if (product.Name.ToLower().Contains(name.ToLower()))
            {
                matchingProducts.Add(product);
            }
        }
        return matchingProducts;
    }

    private void SaveData(List<Product> products)
    {
        string jsonData = JsonSerializer.Serialize(products);
        File.WriteAllText(_filePath, jsonData);
    }
}
}