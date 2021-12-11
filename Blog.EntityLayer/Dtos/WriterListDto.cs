using Blog.CoreLayer.Entities.Abstract;
using Blog.EntityLayer.Concrete;
using System.Collections.Generic;

namespace Blog.EntityLayer.Dtos
{
    public class WriterListDto : DtoGetBase, IDto
    {
        public IList<Writer> Writers { get; set; }
    }
}
