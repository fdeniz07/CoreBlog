using Blog.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Web.ViewComponents
{
    public class CommentListStatic : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    Id = 1,
                    UserName = "Fatih"
                },
                new UserComment
                {
                    Id = 2,
                    UserName = "Cenk"
                },
                new UserComment
                {
                    Id = 3,
                    UserName = "Ayse"
                }
            };
            return View(commentValues);
        }
    }
}
