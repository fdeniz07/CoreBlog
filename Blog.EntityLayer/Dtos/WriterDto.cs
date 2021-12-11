using Blog.CoreLayer.Entities.Abstract;
using Blog.EntityLayer.Concrete;

namespace Blog.EntityLayer.Dtos
{
    public class WriterDto : DtoGetBase, IDto
    {
        public Writer Writer { get; set; }
    }
}
