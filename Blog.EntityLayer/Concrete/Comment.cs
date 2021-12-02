using System;
using Blog.CoreLayer.Entities.Abstract;

namespace Blog.EntityLayer.Concrete
{
    public class Comment : EntityBase, IEntity
    {
        public string UserName { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int ArticleId { get; set; }
        public Article Article { get; set; } // Bir yorum bir makaleye sahip olmak zorundadir

        //Yorum yapmak icin sisteme giris yapilmayi mecbur kilmiyoruz. Gerekirse yazar ve blog arasinda baglanti olusuturulmalidir.
    }
}
