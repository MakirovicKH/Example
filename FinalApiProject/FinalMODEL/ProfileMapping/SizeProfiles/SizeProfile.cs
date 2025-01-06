using AutoMapper;
using FinalMODEL.DTOs.Size;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalMODEL.ProfileMapping.SizeProfiles
{
    public class SizeProfile : Profile
    {
        public SizeProfile()
        {
            CreateMap<SizeDto, Size>();
            CreateMap<Size, SizeDto>();
        }
    }
}
