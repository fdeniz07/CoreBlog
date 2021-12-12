using Blog.EntityLayer.Dtos;

namespace Blog.Web.Models
{
    public class ArticleDetailViewModel
    {
        public ArticleDto ArticleDto { get; set; }
        public WriterAboutModel WriterAboutModel { get; set; }
        public ArticleListDto ArticleListDto { get; set; }
        public WriterArticlesViewModel WriterArticlesViewModel { get; set; }
        public CategoryListDto CategoryListDto { get; set; }
    }
}
