using Microsoft.EntityFrameworkCore;

namespace Blog.DataAccessLayer.Concrete.EntityFramework.Contexts
{
    public class MsDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=APACHIE;database=BlogDb; integrated security=true;");
        }
    }
}
