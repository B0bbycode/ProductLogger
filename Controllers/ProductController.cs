// ProductController.cs
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ProductLog.Models;

namespace ProductLog.Controllers
{
public class ProductController
{
private List<Product> _products;
private string _filePath;
    public ProductController(string filePath)
    {
        _filePath = filePath;
        if (File.Exists(filePath))
        {
            string fileContent = File.ReadAllText(filePath);
            _products = JsonConvert.DeserializeObject<List<Product>>(fileContent);
        }
        else
        {
            _products = new List<Product>();
        }
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
        SaveProductsToFile();
    }

    public List<Product> SearchProductByName(string name)
    {
        List<Product> foundProducts = new List<Product>();
        foreach (Product product in _products)
        {
            if (product.Name.ToLower().Contains(name.ToLower()))
            {
                foundProducts.Add(product);
            }
        }
        return foundProducts;
    }

    public List<Product> GetAllProducts()
    {
        return _products;
    }

    private void SaveProductsToFile()
    {
        string json = JsonConvert.SerializeObject(_products);
        File.WriteAllText(_filePath, json);
    }
}
}