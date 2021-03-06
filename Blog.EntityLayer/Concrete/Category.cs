using System.Collections.Generic;
using Blog.CoreLayer.Entities.Abstract;

namespace Blog.EntityLayer.Concrete
{
    public class Category : EntityBase, IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public override bool IsDeleted { get; set; } = false;
        public ICollection<Article> Articles { get; set; }
    }
}
