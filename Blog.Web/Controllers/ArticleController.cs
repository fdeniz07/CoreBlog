using Blog.BusinessLayer.Abstract;
using Blog.CoreLayer.Utilities.Results.ComplexTypes;
using Blog.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Blog.Web.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;

        public ArticleController(IArticleService articleService, ICategoryService categoryService)
        {
            _articleService = articleService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Detail(int articleId,int writerId)
        {
            var articleResult = await _articleService.GetAsync(articleId);
            var articleResults = await _articleService.GetAllByViewCountAsync(isAscending: false, takeSize: 5); // Azalan bir sekilde yazarin 5 makalesi gelecek
            var categoriesResult = await _categoryService.GetAllByNonDeletedAndActiveAsync(); // Silmemis ve Aktif olan kategoriler

            if (articleResult.ResultStatus == ResultStatus.Success)
            {
                return View(new ArticleDetailViewModel
                {
                    ArticleDto = articleResult.Data,
                    WriterAboutModel = new WriterAboutModel
                    {
                        Writer = articleResult.Data.Article.Writer,
                        Header = ""
                    },
                    WriterArticlesViewModel = new WriterArticlesViewModel
                    {
                        Articles = articleResults.Data.Articles,
                        Categories = categoriesResult.Data.Categories
                    },
                    CategoryListDto = categoriesResult.Data
                });
            }
            return NotFound();
        }
    }
}
