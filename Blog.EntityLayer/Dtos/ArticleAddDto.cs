using System;
using System.ComponentModel.DataAnnotations;
using Blog.CoreLayer.Entities.Abstract;
using Blog.EntityLayer.Concrete;

namespace Blog.EntityLayer.Dtos
{
    public class ArticleAddDto:IDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Thumbnail { get; set; }
        public string Image { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }
        public string SeoAuthor { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTags { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public bool IsActive { get; set; }
    }
}
