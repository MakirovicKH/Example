using FinalMODEL.DTOs.Category;
using FinalMODEL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalBL.İmplementations.Interfaces
{
    public interface ICategoryService
    {
        Task<Category> GetByIdAsync(int id);
        Task<IEnumerable<Category>> GetAllAsync();
        Task AddAsync(CategoryDto entity);
        Task UpdateAsync(Category entity);
        Task SoftDeleteAsync(int id);
        Task HardDeleteAsync(int id);
    }
}
