using Blog.CoreLayer.Entities.Abstract;
using Blog.EntityLayer.Concrete;

namespace Blog.EntityLayer.Dtos
{
    public class CategoryDto : DtoGetBase, IDto
    {
        public Category Category { get; set; }
    }
}
