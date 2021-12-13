using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
