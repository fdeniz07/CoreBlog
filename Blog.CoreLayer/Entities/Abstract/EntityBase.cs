using System;

namespace Blog.CoreLayer.Entities.Abstract
{
    public abstract  class EntityBase
    {
        // Base sinifimiz, tablolarimizdaki ortak alanlari tutar ve miras alan siniflar degisiklik isterlerse override anahtari ile degisiklik yapabilirler.

        public EntityBase() //Varsa, ilk deger atamalari ya constructor üzerinden ya da property üzerinden yapilir.
        {
            CreatedDate = ModifiedDate = DateTime.Now;
            //IsActive = true;
            //IsDeleted = false;
        }
        public virtual int Id { get; set; }
        public virtual DateTime CreatedDate { get; set; } //;= DateTime.Now
        public virtual DateTime ModifiedDate { get; set; } //;= DateTime.Now
        public virtual bool IsDeleted { get; set; } = false;
        public virtual bool IsActive { get; set; } = true;
        public virtual string CreatedByName { get; set; } = "Admin"; //Olusturan kullanici degilse admin olarak default deger atanacak
        public virtual string ModifiedByName { get; set; } = "Admin";
        public virtual string Note { get; set; }
    }
}
