using AutoMapper;
using Blog.EntityLayer.Concrete;
using Blog.EntityLayer.Dtos;

namespace Blog.Web.AutoMapper.Profiles
{
    public class WriterProfile : Profile
    {
        public WriterProfile()
        {
            CreateMap<WriterAddDto, Writer>();

            CreateMap<Writer, WriterUpdateDto>().ReverseMap(); // ReverseMap metodu ayni islemin tersini de yapmaktadir. (WriterUpdateDto --> Writer)
        }
    }
}
