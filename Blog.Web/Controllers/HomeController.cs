using System.Threading.Tasks;
using Blog.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IArticleService _articleService;

        public HomeController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int? categoryId)
        {
            //var values = await _articleService.GetAllAsync();
            var articlesResult = await (categoryId == null
                ? _articleService.GetAllByNonDeletedAndActiveAsync()
                : _articleService.GetAllByCategoryAsync(categoryId.Value));
            return View(articlesResult.Data);
            //return View(values.Data);
        }
    }
}
