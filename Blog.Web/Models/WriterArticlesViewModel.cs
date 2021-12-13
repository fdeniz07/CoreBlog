using System.Collections.Generic;
using Blog.EntityLayer.Concrete;

namespace Blog.Web.Models
{
    public class WriterArticlesViewModel
    {
        public IList<Category> Categories { get; set; }
        public IList<Article> Articles { get; set; }
        public string Header { get; set; }
    }
}
 