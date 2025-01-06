using FinalMODEL.DTOs.User;
using FinalMODEL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalBL.İmplementations.Interfaces
{
    public interface IRegisterService
    {
        Task<AppUser> RegisterAsync(CreateUserDto userDto);



    }
}
