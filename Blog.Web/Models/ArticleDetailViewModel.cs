using Blog.EntityLayer.Dtos;

namespace Blog.Web.Models
{
    public class ArticleDetailViewModel
    {
        public ArticleDto ArticleDto { get; set; } //Yorumlar ve Yazar Hakkinda icin gerekli
        public WriterArticlesViewModel WriterArticlesViewModel { get; set; } // Yazar Makaleleri icin gerekli
        public CategoryListDto CategoryListDto { get; set; } // Kategori Listesi icin gerekli
    }
}
