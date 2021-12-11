using Blog.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Blog.Web.ViewComponents.Writer
{
    public class WriterAboutViewComponent : ViewComponent
    {
        private readonly IWriterService _writerService;

        public WriterAboutViewComponent(IWriterService writerService)
        {
            _writerService = writerService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int writerId)
        {
            var writerResult = await _writerService.GetAsync(writerId);
            return View();
        }
    }
}
