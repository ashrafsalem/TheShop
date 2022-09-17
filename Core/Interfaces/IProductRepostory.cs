using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepostory
    {
        public Task<Products> GetProductByIdAsync(int id);
        public Task<IReadOnlyList<Products>> GetProductsAsync();
        public Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync();
        public Task<IReadOnlyList<ProductType>> GetProductTypeAsync();
    }
}