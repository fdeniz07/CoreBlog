using Blog.CoreLayer.Entities.Abstract;

namespace Blog.EntityLayer.Dtos
{
    public class CategoryAddDto:IDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public bool IsActive { get; set; }
    }
}
