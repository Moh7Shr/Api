using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ProductRepository : IProductRepository
    {
        public Task<IReadOnlyList<Product>> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
