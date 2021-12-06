using System;
using AutoMapper;
using Blog.EntityLayer.Concrete;
using Blog.EntityLayer.Dtos;

namespace Blog.BusinessLayer.AutoMapper.Profiles
{
    public class ArticleProfile:Profile
    {
        public ArticleProfile()
        {
            //Burada amac; blog icerisinde CreatedDate alani var ama Dto da yok. Bizim verecegimiz islemlerle bu dönüstürme islemlerini gerceklestiriyor

            CreateMap<ArticleAddDto, Article>().ForMember(dest=>dest.CreatedDate, opt=> opt.MapFrom(x=>DateTime.Now));
            
            CreateMap<ArticleUpdateDto, Article>().ForMember(dest=>dest.ModifiedDate, opt=>opt.MapFrom(x=>DateTime.Now));

            CreateMap<Article, ArticleUpdateDto>();

        }
    }
}
