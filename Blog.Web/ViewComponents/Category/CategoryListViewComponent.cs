using System.Threading.Tasks;
using Blog.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.ViewComponents.Category
{
    public class CategoryListViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
