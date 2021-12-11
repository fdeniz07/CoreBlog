using System.Collections.Generic;
using Blog.EntityLayer.Concrete;
using Blog.EntityLayer.Dtos;

namespace Blog.Web.Models
{
    public class  CommentViewModel
    {
        public IList<Comment> Comments { get; set; }
        public Comment Comment { get; set; }
        public IList<Article> Articles { get; set; }
    }
}
