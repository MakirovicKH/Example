using AutoMapper;
using FinalMODEL.DTOs.User;
using FinalMODEL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalMODEL.ProfileMapping.UserProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<CreateUserDto, AppUser>();
        }
    }
}
