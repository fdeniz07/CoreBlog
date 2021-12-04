using Blog.DataAccessLayer.Abstract.Repositories;
using Blog.DataAccessLayer.Abstract.UnitOfWorks;
using Blog.DataAccessLayer.Concrete.EntityFramework.Contexts;
using Blog.DataAccessLayer.Concrete.EntityFramework.Repositories;
using System.Threading.Tasks;

namespace Blog.DataAccessLayer.Concrete.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        //Kendi Context nesnemizi DI ile cagiriyoruz.
        private readonly MsDbContext _context;
        public UnitOfWork(MsDbContext context)
        {
            _context = context;
        }

        private EfAboutRepository _aboutRepository;
        private EfArticleRepository _articleRepository;
        private EfCategoryRepository _categoryRepository;
        private EfCommentRepository _commentRepository;
        private EfContactRepository _contactRepository;
        private EfRoleRepository _roleRepository;
        private EfWriterRepository _writerRepository;

        #region Implementation of IUnitOfWork
        //Interface den implemente ettigimiz property ler lamda expression ile instance olusturulur (yok ise)

        // ?? (null-coalescing) operatörü sayesinde bir degiskenin degerinin null oldugu durumda alternatif deger döndürebiliriz.
        public IAboutRepository Abouts => _aboutRepository = _aboutRepository ?? new EfAboutRepository(_context);
        public IArticleRepository Articles => _articleRepository = _articleRepository ?? new EfArticleRepository(_context);
        public ICategoryRepository Categories => _categoryRepository ??= new EfCategoryRepository(_context);
        public ICommentRepository Comments => _commentRepository ??= new EfCommentRepository(_context);
        public IContactRepository Contacts => _contactRepository ??= new EfContactRepository(_context);
        public IRoleRepository Roles => _roleRepository ??= new EfRoleRepository(_context);
        public IWriterRepository Writers => _writerRepository ??= new EfWriterRepository(_context);
        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
        #endregion

        #region Implementation of IDisposable
        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
        #endregion
    }
}
