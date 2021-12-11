using Blog.EntityLayer.Concrete;
using Blog.EntityLayer.Dtos;

namespace Blog.Web.Models
{
    public class WriterAboutModel
    {
        //public WriterDto WriterDto { get; set; }
        public Writer Writer { get; set; }
        public string Header { get; set; }
    }
}
