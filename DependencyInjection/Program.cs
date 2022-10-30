
using DependencyInjection.Models;

Product product = new Product();
product.Name = "Çağatay";
product.Price = 333;

ILogger logger = new XMLLogger();
ProductManager manager = new ProductManager(logger);

manager.AddProduct(product);

Console.Read();
