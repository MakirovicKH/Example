using AutoMapper;
using FinalMODEL.DTOs.Color;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalMODEL.ProfileMapping.ColorProfiles
{
    public class ColorProfile : Profile
    {
        public ColorProfile()
        {
            CreateMap<ColorDto, Color>();
            CreateMap<Color, ColorDto>();
        }
    }
}
