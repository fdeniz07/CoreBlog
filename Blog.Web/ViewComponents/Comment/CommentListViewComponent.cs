using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Blog.Web.ViewComponents.Comment
{
    public class CommentListViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
