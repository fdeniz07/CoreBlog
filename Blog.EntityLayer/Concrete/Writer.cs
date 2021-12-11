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
        public string UserName { get; set; }
        public byte[] PasswordHash{ get; set; }
        public string YoutubeLink { get; set; }
        public string TwitterLink { get; set; }
        public string InstagramLink { get; set; }
        public string FacebookLink { get; set; }
        public string LinkedInLink { get; set; }
        public string GitHubLink { get; set; }
        public string WebsiteLink { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}
