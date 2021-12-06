using Blog.CoreLayer.Entities.Abstract;
using Blog.EntityLayer.Concrete;
using System.Collections.Generic;

namespace Blog.EntityLayer.Dtos
{
    public class ArticleListDto : DtoGetBase, IDto
    {
        public IList<Article> Articles { get; set; }

    }
}
