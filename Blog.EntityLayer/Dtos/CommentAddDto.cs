using Blog.CoreLayer.Entities.Abstract;

namespace Blog.EntityLayer.Dtos
{
    public class CommentAddDto:IDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string CreatedByName { get; set; }
        public int ArticleId { get; set; }
    }
}
