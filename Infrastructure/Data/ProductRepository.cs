using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext _context;

        public ProductRepository(StoreContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<ProductBrand>> GetAllProductBrands()
        {
            return await _context.ProductBrands.ToListAsync();
        }

        public async Task<IReadOnlyList<Product>> GetAllProducts()
        {
            return await _context.products
                .Include(p => p.ProductPrand)
                .Include(p => p.PoductType)
                .ToListAsync();
        }

        public async Task<IReadOnlyList<ProductType>> GetAllProductTypes()
        {
            return await _context.ProductTypes.ToListAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _context.products
                .Include(p => p.ProductPrand)
                .Include(p => p.PoductType)
                .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
