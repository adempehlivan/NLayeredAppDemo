using Nortwind.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nortwind.Entities.Concrete;

namespace Nortwind.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : IProductDal
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            List<Product> products = new List<Product> {
                new Product { CategoryId = 1, ProductId = 1, ProductName = "Laptop", QuantityPerUnit = "1 in a box", UnitPrice = 3000, UnitsInStock = 11 }};
            return products;
    }

    public void Update(Product product)
    {
        throw new NotImplementedException();
    }
}
}
