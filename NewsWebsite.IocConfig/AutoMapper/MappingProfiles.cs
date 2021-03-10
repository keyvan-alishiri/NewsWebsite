using AutoMapper;
using NewsWebsite.Entities;
using NewsWebsite.ViewModels.Category;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsWebsite.IocConfig.AutoMapper
{
   public class MappingProfiles :Profile
    {
        public MappingProfiles()
        {
            CreateMap<Category, CategoryViewModel>().ReverseMap()
                .ForMember(p => p.Parent, opt => opt.Ignore())
                .ForMember(p => p.Categories, opt => opt.Ignore())
                .ForMember(p => p.NewsCategories, opt => opt.Ignore());
        }
    }
}
