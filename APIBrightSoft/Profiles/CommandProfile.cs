using APIBrightSoft.DOts;
using APIBrightSoft.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBrightSoft.Profiles
{
    public class CommandProfile : Profile
    {
        public CommandProfile()
        {
            //Source->Target, профили для мапинга
            CreateMap<Command, CommandReadDTO>();
            CreateMap<SecondTable, SecondTableDTO>();
            CreateMap<ThirdTable, ThirdTableDTO>();

        }
    }
}
