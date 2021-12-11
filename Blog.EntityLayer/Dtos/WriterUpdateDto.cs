using System.ComponentModel.DataAnnotations;
using Blog.CoreLayer.Entities.Abstract;
using Microsoft.AspNetCore.Http;

namespace Blog.EntityLayer.Dtos
{
    public class WriterUpdateDto : IDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [DataType(DataType.Upload)]
        public IFormFile ImageFile { get; set; }

        public string Image { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string About { get; set; }
        public string TwitterLink { get; set; }
        public string FacebookLink { get; set; }
        public string InstagramLink { get; set; }
        public string LinkedInLink { get; set; }
        public string YoutubeLink { get; set; }
        public string GitHubLink { get; set; }
        public string WebsiteLink { get; set; }
    }
}
