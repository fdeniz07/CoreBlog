using Blog.BusinessLayer.Abstract;
using Blog.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Blog.Web.ViewComponents.ArticleDetailsRightSideBar
{
    public class RightSideBarViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        private readonly IArticleService _articleService;

        public RightSideBarViewComponent(ICategoryService categoryService, IArticleService articleService)
        {
            _categoryService = categoryService;
            _articleService = articleService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categoriesResult = await _categoryService.GetAllByNonDeletedAndActiveAsync();
            var articlesResults = await _articleService.GetAllByViewCountAsync(isAscending: false, takeSize: 5); // Azalan bir sekilde 5 makale gelecek

            return View(new WriterArticlesViewModel
            {
                Categories = categoriesResult.Data.Categories,
                Articles = articlesResults.Data.Articles
            });
        }
    }
}
