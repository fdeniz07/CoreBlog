using Blog.CoreLayer.Entities.Abstract;

namespace Blog.EntityLayer.Dtos
{
    public class CommentUpdateDto:IDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsActive { get; set; }
        public int ArticleId { get; set; }
    }
}
