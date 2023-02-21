using EnocaProject.Business.Abstract;
using EnocaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaProject.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductService _productService;
        public ProductManager(IProductService productService)
        {
            _productService = productService;
        }

        public void Add(Product product)
        {
            _productService.Add(product);
        }

        public void Delete(int productId)
        {
            _productService.Delete(productId);
        }

        public List<Product> GetAll()
        {
          return  _productService.GetAll();
        }

        public void Update(Product product)
        {
            _productService.Update(product);
        }
    }
}
