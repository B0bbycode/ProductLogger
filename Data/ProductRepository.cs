// ProductRepository.cs
using System.Collections.Generic;
using ProductLog.Controllers;
using ProductLog.Models;

namespace ProductLog.Data
{
public class ProductRepository
{
private ProductController _productController;
    public ProductRepository(string filePath)
    {
        _productController = new ProductController(filePath);
    }

    public void AddProduct(Product product)
    {
        _productController.AddProduct(product);
    }

    public List<Product> SearchProductByName(string name)
    {
        return _productController.SearchProductByName(name);
    }

    public List<Product> GetAllProducts()
    {
        return _productController.GetAllProducts();
    }
}
}