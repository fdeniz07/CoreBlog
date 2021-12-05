using Blog.CoreLayer.Entities.Abstract;

namespace Blog.EntityLayer.Dtos
{
    public class CategoryUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
