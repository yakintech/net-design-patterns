using System;
namespace DependencyInjection.Models
{
    public class ProductManager
    {

        ILogger _logger;

        public ProductManager(ILogger logger)
        {
            this._logger = logger;
        }


        public void AddProduct(Product product)
        {
            _logger.PrintLog();
            //Ninja ekleme işlemleri
        }
    }
}

