using System;
using Blog.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.DataAccessLayer.Concrete.Mapping
{
    public class RoleMap : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r=>r.Id).UseIdentityColumn();
            builder.Property(r=>r.Id).ValueGeneratedOnAdd();
            builder.Property(r => r.Name).IsRequired().HasMaxLength(30);
            builder.Property(r=>r.Description).IsRequired().HasMaxLength(250);
            builder.Property(r=>r.CreatedByName).IsRequired().HasMaxLength(50);
            builder.Property(r=>r.ModifiedByName).IsRequired().HasMaxLength(50);
            builder.Property(r=>r.CreatedDate).IsRequired();
            builder.Property(r=>r.ModifiedDate).IsRequired();
            builder.Property(r=>r.IsActive).IsRequired();
            builder.Property(r=>r.IsDeleted).IsRequired();
            builder.Property(r=>r.Note).HasMaxLength(500);

            builder.ToTable("Roles");

            //ilk deger atamasi (Fluent Api ile tüm degerler girilmedir (null gecilebilir olsa da))

            builder.HasData(new Role
            {
                Id=1,
                Name="Admin",
                Description = "Admin Rolü, Tüm Haklara Sahiptir",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                Note = "Admin Rolüdür."
            });
        }
    }
}
