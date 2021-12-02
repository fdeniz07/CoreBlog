using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.DataAccessLayer.Concrete.Mapping
{
    public class ContactMap : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn();
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Subject).IsRequired().HasMaxLength(25);
            builder.Property(c => c.Message).IsRequired().HasMaxLength(500);
            builder.Property(c => c.Mail).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Name).IsRequired().HasMaxLength(25);
            builder.Property(c => c.CreatedByName).IsRequired().HasMaxLength(50);
            builder.Property(c => c.ModifiedByName).IsRequired().HasMaxLength(50);
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.ModifiedDate).IsRequired();
            builder.Property(c => c.IsActive).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.Property(c => c.Note).HasMaxLength(500);

            builder.ToTable("Contacts");
        }
    }
}
