using AutoMapper;
using FinalBL.İmplementations.Interfaces;
using FinalMODEL.DTOs.User;
using FinalMODEL.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalBL.İmplementations.Services
{
    public class RegisterService : IRegisterService
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IEmailSender _emailSender;
        private readonly IMapper _mapper;


        public RegisterService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager, IEmailSender emailSender, IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _emailSender = emailSender;
            _mapper = mapper;
        }


        public async Task<AppUser> RegisterAsync(CreateUserDto userDto)
        {

            if (userDto.Password != userDto.ConfirmPassword)
            {
                throw new NotImplementedException("Password and ConfirmPassword do not match");
            }


            var user = _mapper.Map<AppUser>(userDto);

            var result = await _userManager.CreateAsync(user, userDto.Password);

            if (!result.Succeeded)
            {
                throw new NotImplementedException("Unsuccesful registraction");
            }

            await _userManager.AddToRoleAsync(user, "User");

            return user;
        }
    }
}
