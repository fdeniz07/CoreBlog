using System.Collections.Generic;
using Blog.CoreLayer.Entities.Abstract;

namespace Blog.EntityLayer.Concrete
{
    public class Writer : EntityBase, IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string About { get; set; }
        public string Image { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash{ get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
