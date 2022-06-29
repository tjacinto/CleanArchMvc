using CleanArchMvc.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Category>> GetProductsAsync();
        Task<Category> GetByIdAsync(int? id);
        Task<Category> GetProductCategoryAsync(int? id);
        Task<Category> CreateAsync(Category product);
        Task<Category> UpdateAsync(Category product);
        Task<Category> RemoveAsync(Category product);
    }
}
