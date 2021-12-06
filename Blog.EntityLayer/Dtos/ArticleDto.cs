using Blog.CoreLayer.Entities.Abstract;
using Blog.CoreLayer.Utilities.Results.ComplexTypes;
using Blog.EntityLayer.Concrete;

namespace Blog.EntityLayer.Dtos
{
    public class ArticleDto: DtoGetBase, IDto
    {
        public Article Article { get; set; }

    }
}
