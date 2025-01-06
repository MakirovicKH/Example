using FinalMODEL.DTOs.Size;
using FinalMODEL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalBL.İmplementations.Interfaces
{
    public interface ISizeService
    {
        Task<Size> GetByIdAsync(int id);
        Task<IEnumerable<Size>> GetAllAsync();
        Task AddAsync(SizeDto entity);
        Task UpdateAsync(Size entity);
        Task SoftDeleteAsync(int id);
        Task HardDeleteAsync(int id);
    }
}
