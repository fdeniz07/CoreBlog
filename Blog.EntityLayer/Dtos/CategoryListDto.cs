using System.Collections.Generic;
using Blog.CoreLayer.Entities.Abstract;
using Blog.EntityLayer.Concrete;

namespace Blog.EntityLayer.Dtos
{
    public class CategoryListDto : DtoGetBase, IDto
    {
        public IList<Category> Categories { get; set; }
    }
}
