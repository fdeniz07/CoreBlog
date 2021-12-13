using AutoMapper;
using Blog.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IWriterService _writerService;
        private readonly IMapper _mapper;

        public RegisterController(IWriterService writerService, IMapper mapper)
        {
            _writerService = writerService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            if (ModelState.IsValid)
            {
                
            }
            return View();
        }
    }
}
