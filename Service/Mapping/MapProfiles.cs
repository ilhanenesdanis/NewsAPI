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
            //Category
            CreateMap<Category,ListCategoryDto>().ReverseMap();
            CreateMap<Category,AddCategoryDTO>().ReverseMap();
            //ConstantSeo
            CreateMap<ConstantSeo,ListConstantSeoDto>().ReverseMap();
            CreateMap<ConstantSeo,AddConstantSeoDTO>().ReverseMap();
            //News
            CreateMap<News,ListNewsDto>().ReverseMap();
            CreateMap<News,AddNewsDTO>().ReverseMap();
            //NewsCategory
            CreateMap<NewsCategory,ListNewsCategoryDto>().ReverseMap();
            CreateMap<NewsCategory,AddNewsCategoryDTO>().ReverseMap();
            //NewsTag
            CreateMap<NewsTag,ListNewsTagDto>().ReverseMap();
            CreateMap<NewsTag,AddNewsTagDto>().ReverseMap();
        }
    }
}
