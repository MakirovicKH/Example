using FinalMODEL.DTOs.Color;
using FinalMODEL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalBL.İmplementations.Interfaces
{
    public interface IColorService
    {
        Task<Color> GetByIdAsync(int id);
        Task<IEnumerable<Color>> GetAllAsync();
        Task AddAsync(ColorDto entity);
        Task UpdateAsync(Color entity);
        Task SoftDeleteAsync(int id);
        Task HardDeleteAsync(int id);
    }
}
