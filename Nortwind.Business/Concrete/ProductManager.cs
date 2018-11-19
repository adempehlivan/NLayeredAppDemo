using Nortwind.Business.Abstract;
using Nortwind.DataAccess.Abstract;
using Nortwind.DataAccess.Concrete;
using Nortwind.DataAccess.Concrete.EntityFramework;
using Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.Business.Concrete
{


    public class ProductManager :IProductService
    {
        private IProductDal _productDal;


        public ProductManager(  IProductDal productDal)
        {
            _productDal = productDal;
        } 

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }
    }
}
