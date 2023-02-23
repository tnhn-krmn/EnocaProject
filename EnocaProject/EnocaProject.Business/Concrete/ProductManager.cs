using EnocaProject.Business.Abstract;
using EnocaProject.Business.Constants;
using EnocaProject.Core.Utilities.Results;
using EnocaProject.DataAccess.Abstract;
using EnocaProject.DataAccess.Concrete.EntityFramework;
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
        private readonly IProductDAL _productDAL;

        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public IResult Add(Product product)
        {
            _productDAL.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Product product)
        {
            _productDAL.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IResult Update(Product product)
        {

            _productDAL.Update(product);
            return new SuccessResult(Messages.ProductUpdated);
        }

        public IDataResult<List<Product>> GetList()
        {
            var data = _productDAL.GetList();
            return new SuccessDataResult<List<Product>>(data, Messages.ProductListed);
        }
    }
}
