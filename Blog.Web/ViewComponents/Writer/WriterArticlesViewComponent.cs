using System.Threading.Tasks;
using Blog.BusinessLayer.Abstract;
using Blog.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.ViewComponents.Writer
{
    public class WriterArticlesViewComponent : ViewComponent
    {
        private readonly IWriterService _writerService;
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;

        public WriterArticlesViewComponent(IWriterService writerService, IArticleService articleService, ICategoryService categoryService)
        {
            _writerService = writerService;
            _articleService = articleService;
            _categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            //var categoriesResult = await _categoryService.GetAllByNonDeletedAndActiveAsync();
            //var articlesResult = await _articleService.GetAllByViewCountAsync(isAscending: false, takeSize: 5); // Azalan bir sekilde 5 makale gelecek
            return View();
        }
    }
}
