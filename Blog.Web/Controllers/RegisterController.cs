using System.Threading.Tasks;
using AutoMapper;
using Blog.BusinessLayer.Abstract;
using Blog.EntityLayer.Concrete;
using Blog.EntityLayer.Dtos;
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

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(WriterAddDto writerAddDto)
        {
            var writer = _mapper.Map<Writer>(writerAddDto);
            var result = await _writerService.AddAsync(writerAddDto);

            return View();
        }
    }
}
