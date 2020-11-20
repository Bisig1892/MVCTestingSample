using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTestingSample.Models.Interfaces
{
    interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(int id);

        Task<IEnumerable<Product>> GetAllProductAsync();

        Task AddProductAsync(Product p);

        Task UpdateProductAsync(Product p);

        Task DeleteProductAsync(Product p);

    }
}
