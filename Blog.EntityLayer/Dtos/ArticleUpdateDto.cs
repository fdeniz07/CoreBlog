using System;
using Blog.CoreLayer.Entities.Abstract;
using Blog.EntityLayer.Concrete;

namespace Blog.EntityLayer.Dtos
{
    public class ArticleUpdateDto:IDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Thumbnail { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; }
        public string SeoAuthor { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTags { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public int WriterId { get; set; }
    }
}
