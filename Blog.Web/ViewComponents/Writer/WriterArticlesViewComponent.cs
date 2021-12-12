using System.Threading.Tasks;
using Blog.BusinessLayer.Abstract;
using Blog.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.ViewComponents.Writer
{
    public class WriterArticlesViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
