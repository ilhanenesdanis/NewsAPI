using AutoMapper;
using DTO.AddOrUpdateDto;
using DTO.ListDto;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Mapping
{
    public class MapProfiles : Profile
    {
        public MapProfiles()
        {
            //Tag
            CreateMap<Tag, ListTagDto>().ReverseMap();
            CreateMap<Tag, AddTagDTO>().ReverseMap();
            //Language
            CreateMap<Language, LanguageDto>().ReverseMap();
        }
    }
}
