using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Controllers
{
    public class CommentController : Controller
    {
        [HttpPost]
        public PartialViewResult Add()
        {
            return PartialView("CommentAddPartial");
        }
    }
}
