using Blog.CoreLayer.Entities.Abstract;
using Blog.EntityLayer.Concrete;

namespace Blog.EntityLayer.Dtos
{
    public class CommentDto:IDto
    {
        public Comment Comment { get; set; }
    }
}
