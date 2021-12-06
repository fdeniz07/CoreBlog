using AutoMapper;
using Blog.DataAccessLayer.Abstract.UnitOfWorks;

namespace Blog.BusinessLayer.Concrete
{
    public class ManagerBase
    {
        public ManagerBase(IUnitOfWork unitOfWork, IMapper mapper)
        {
            UnitOfWork = unitOfWork;
            Mapper = mapper;
        }

        protected IUnitOfWork UnitOfWork { get; }

        protected IMapper Mapper { get; }
    }
}
