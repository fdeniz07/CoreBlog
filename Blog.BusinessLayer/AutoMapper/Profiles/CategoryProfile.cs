﻿using System;
using AutoMapper;
using Blog.EntityLayer.Concrete;
using Blog.EntityLayer.Dtos;

namespace Blog.BusinessLayer.AutoMapper.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryAddDto, Category>()
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(x => DateTime.Now));
            
            CreateMap<CategoryUpdateDto, Category>()
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now));
            
            CreateMap<Category, CategoryUpdateDto>();
        }
    }
}
