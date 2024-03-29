﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductById(int id);
        Task<IReadOnlyList<Product>> GetAllProducts();
        Task<IReadOnlyList<ProductBrand>> GetAllProductBrands();
        Task<IReadOnlyList<ProductType>> GetAllProductTypes();
    }
}
