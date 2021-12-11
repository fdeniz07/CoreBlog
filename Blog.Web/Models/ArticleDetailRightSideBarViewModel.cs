using System.Collections.Generic;
using Blog.EntityLayer.Concrete;
using Blog.EntityLayer.Dtos;

namespace Blog.Web.Models
{
    public class ArticleDetailRightSideBarViewModel
    {
        public string Header { get; set; }
        public ArticleListDto ArticleListDto { get; set; }
        public Writer Writer { get; set; }
        public WriterArticlesViewModel RightSideBarViewModel { get; set; }
        //public ArticleDto ArticleDto { get; set; }
    }
}
