namespace Blog.BusinessLayer.Utilities
{
    public static class Messages
    {
        // Messages.Category.NotFound();

        public static class General
        {
            public static string ValidationError()
            {
                return $"Bir veya daha fazla validasyon hatası ile karşılaşıldı.";
            }
        }

        public static class Category // Buradaki Category sinifi entity bölümünden farklidir
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiç bir kategori bulunamadı.";
                return "Böyle bir kategori bulunamadı.";
            }

            public static string NotFoundById(int categoryId)
            {
                return $"{categoryId} kategori koduna ait bir kategori bulunamadı.";
            }

            public static string Add(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla eklenmiştir";
            }

            public static string Update(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla güncellenmiştir.";
            }

            public static string Delete(string categoryName)
            {
                return $"{categoryName}  adlı kategori başarıyla silinmistir.";
            }

            public static string UndoDelete(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla arşivden geri getirilmiştir.";
            }

            public static string HardDelete(string categoryName)
            {
                return $"{categoryName} adlı kategori veritabanindan başarıyla silinmiştir.";
            }
        }

        public static class Article // Buradaki Article sinifi entity bölümünden farklidir
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Makaleler bulunamadı.";
                return "Böyle bir makale bulunamadı.";
            }

            public static string NotFoundById(int articleId)
            {
                return $"{articleId} makale koduna ait bir makale bulunamadı.";
            }

            public static string Add(string title)
            {
                return $"{title} başlıklı makale başarıyla eklenmiştir.";
            }

            public static string Update(string title)
            {
                return $"{title} baslikli makale başariyla güncellenmiştir.";
            }

            public static string Delete(string title)
            {
                return $"{title}  başlıklı makale başarıyla silinmiştir.";
            }

            public static string UndoDelete(string title)
            {
                return $"{title} adlı makale başarıyla arşivden geri getirilmiştir.";
            }
            public static string HardDelete(string title)
            {
                return $"{title} başlıklı makale veritabanından başarıyla silinmiştir.";
            }
            public static string IncreaseViewCount(string title)
            {
                return $"{title} başlıklı makalenin okunma sayısı başarıyla arttırılmıştır.";
            }
        }

        public static class Comment
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiç bir yorum bulunamadı.";
                return "Böyle bir yorum bulunamadı.";
            }

            public static string Approve(int commentId)
            {
                return $"{commentId} no'lu yorum başarıyla onaylanmıştır.";
            }

            public static string Add(string createdByName)
            {
                return $"Sayın {createdByName}, yorumunuz başarıyla eklenmiştir.";
            }

            public static string Update(string createdByName)
            {
                return $"{createdByName} tarafından eklenen yorum başarıyla güncellenmiştir.";
            }
            public static string Delete(string createdByName)
            {
                return $"{createdByName} tarafından eklenen yorum başarıyla silinmiştir.";
            }
            public static string UndoDelete(string createdByName)
            {
                return $"{createdByName} tarafından eklenen yorum başarıyla arşivden geri getirilmiştir.";
            }

            public static string HardDelete(string createdByName)
            {
                return $"{createdByName} tarafından eklenen yorum başarıyla veritabanından silinmiştir.";
            }
        }

        public static class Writer // Buradaki Writer sinifi entity bölümünden farklidir
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiç bir yazar bulunamadı.";
                return "Böyle bir yazar bulunamadı.";
            }

            public static string NotFoundById(int writerId)
            {
                return $"{writerId} yazar koduna ait bir yazar bulunamadı.";
            }

            public static string Add(string writerName)
            {
                return $"{writerName} adlı yazar başarıyla eklenmiştir";
            }

            public static string Update(string writerName)
            {
                return $"{writerName} adlı yazar başarıyla güncellenmiştir.";
            }

            public static string Delete(string writerName)
            {
                return $"{writerName}  adlı yazar başarıyla silinmistir.";
            }

            public static string UndoDelete(string writerName)
            {
                return $"{writerName} adlı yazar başarıyla arşivden geri getirilmiştir.";
            }

            public static string HardDelete(string writerName)
            {
                return $"{writerName} adlı yazar veritabanindan başarıyla silinmiştir.";
            }
        }
    }
}
