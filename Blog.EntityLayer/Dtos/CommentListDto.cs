using System.Collections.Generic;
using Blog.CoreLayer.Entities.Abstract;
using Blog.EntityLayer.Concrete;

namespace Blog.EntityLayer.Dtos
{
    public class CommentListDto:IDto
    {
        public IList<Comment> Comments { get; set; }
    }
}
