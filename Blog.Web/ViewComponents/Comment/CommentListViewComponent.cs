using Blog.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Blog.Web.ViewComponents.Comment
{
    public class CommentListViewComponent : ViewComponent
    {
        private readonly ICommentService _commentService;
        private readonly IArticleService _articleService;

        public CommentListViewComponent(ICommentService commentService, IArticleService articleService)
        {
            _commentService = commentService;
            _articleService = articleService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int articleId)
        {
            var articleResult = await _articleService.GetAsync(articleId);
            return View();
        }
    }
}
