using Blog.DataAccessLayer.Concrete.Mapping;
using Blog.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Blog.DataAccessLayer.Concrete.EntityFramework.Contexts
{
    public class MsDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=APACHIE;Initial Catalog=BlogDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        //Migration icin buraya Entity'lerimizi eklememiz gerekmektedir
        public DbSet<About> Abouts { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        //FluentApi Ayarlarinin gecerli olmasi icin tüm entity lere ait map dosyalari asagiya yazilmalidir.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AboutMap());
            modelBuilder.ApplyConfiguration(new ArticleMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new CommentMap());
            modelBuilder.ApplyConfiguration(new ContactMap());
            modelBuilder.ApplyConfiguration(new RoleMap());
            modelBuilder.ApplyConfiguration(new WriterMap());
        }
    }
}
