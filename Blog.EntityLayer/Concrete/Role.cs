using System.Collections.Generic;
using System.Reflection.Metadata;
using Blog.CoreLayer.Entities.Abstract;

namespace Blog.EntityLayer.Concrete
{
    public class Role : EntityBase, IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Writer> Writers { get; set; }
    }
}
