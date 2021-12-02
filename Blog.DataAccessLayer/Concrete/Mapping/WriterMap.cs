using System;
using System.Text;
using Blog.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.DataAccessLayer.Concrete.Mapping
{
    public class WriterMap : IEntityTypeConfiguration<Writer>
    {
        public void Configure(EntityTypeBuilder<Writer> builder)
        {
            builder.HasKey(w => w.Id);
            builder.Property(w => w.Id).UseIdentityColumn();
            builder.Property(w => w.Id).ValueGeneratedOnAdd();
            builder.Property(w => w.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(w => w.LastName).IsRequired().HasMaxLength(100);
            builder.Property(w => w.About).HasMaxLength(250);
            builder.Property(w => w.Image).HasMaxLength(250);
            builder.Property(w => w.Email).IsRequired().HasMaxLength(50);
            builder.Property(w => w.CreatedByName).IsRequired().HasMaxLength(50);
            builder.Property(w => w.ModifiedByName).IsRequired().HasMaxLength(50);
            builder.Property(w => w.CreatedDate).IsRequired();
            builder.Property(w => w.ModifiedDate).IsRequired();
            builder.Property(w => w.IsActive).IsRequired();
            builder.Property(w => w.IsDeleted).IsRequired();
            builder.Property(w => w.Note).HasMaxLength(500);

            builder.ToTable("Writers");

            //ilk deger atamasi (Fluent Api ile tüm degerler girilmedir (null gecilebilir olsa da))

            builder.HasData(
                new Writer
                {
                    Id = 1,
                    RoleId = 1,
                    FirstName = "Fatih",
                    LastName = "Deniz",
                    About="Blog Admin",
                    Email = "admin@gmail.com",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "Ilk Admin Kullanici",
                    Image = "default.jpg",
                    PasswordHash = Encoding.ASCII.GetBytes("0192023a7bbd73250516f069df18b500") //	admin123 MD5 = 0192023a7bbd73250516f069df18b500   https://www.md5hashgenerator.com/
                });
        }
    }
}

