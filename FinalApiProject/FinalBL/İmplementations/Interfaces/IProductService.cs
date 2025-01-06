using FinalMODEL.DTOs.Product;
using FinalMODEL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalBL.İmplementations.Interfaces
{
    public interface IProductService
    {
        Task<Product> GetByIdAsync(int id);
        Task<IEnumerable<Product>> GetAllAsync();
        Task AddAsync(CreateProductDto entity);
        Task UpdateAsync(Product entity);
        Task SoftDeleteAsync(int id);
        Task HardDeleteAsync(int id);
    }
}
