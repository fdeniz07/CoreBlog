using Blog.CoreLayer.Entities.Abstract;
using System;

namespace Blog.EntityLayer.Concrete
{
    public class Blog : EntityBase, IEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string ThumbnailImage { get; set; }
        public string Image { get; set; }
        public DateTime Date  { get; set; }
        public int ViewCount { get; set; } = 0; //Baslangic degeri public int CommentCount { get; set; } = 0; //Baslangic degeri
        public string SeoAuthor { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTags { get; set; }
    }
}
