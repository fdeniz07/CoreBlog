using System;
using Blog.CoreLayer.Utilities.Results.Abstract;
using Blog.EntityLayer.Concrete;
using Blog.EntityLayer.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.BusinessLayer.Abstract
{
    public interface IArticleService
    {
        //Metotlarimizi simdilik Entity'ler üzerinden yapacagiz. Ileri de bu Entity alanlarini kuracagimiz DTO'lar ile degistirecegiz.

        //DTO : Data Transfer Object anlamina gelen, Frontend tarafinda kullanicinin ihtiyac duyacagi ilgili entity'lere ait property'leri tutar.
        Task<IDataResult<ArticleDto>> GetAsync(int articleId);
       
        Task<IDataResult<ArticleDto>> GetByIdAsync(int blogId, bool includeCategory, bool includeComments, bool includeUser);
        
        Task<IDataResult<ArticleListDto>> GetArticleUpdateDtoAsync(int articleId);
      
        Task<IDataResult<ArticleListDto>> GetAllAsync();
        //Task<IDataResult<ArticleListDto>> GetAllAsync();
       
        //Task<IDataResult<ArticleListDto>> GetAllAsyncV2(int? categoryId, int? userId, bool? isActive, bool? isDeleted, int currentPage, int pageSize, OrderByGeneral orderBy, bool isAscending, bool includeCategory, bool includeComments, bool includeUser); //GetAllAsyncV2 metodudu tüm GetAll siniflarini kapsamakta ve daha performansli calismaktadir. Tüm sartlari icerisinde barindirmakadir.

        Task<IDataResult<ArticleListDto>> GetAllByNonDeletedAsync();
        //Task<IDataResult<ArticleListDto>> GetAllByNonDeletedAsync();
       
        Task<IDataResult<ArticleListDto>> GetAllByNonDeletedAndActiveAsync();
        
        Task<IDataResult<ArticleListDto>> GetAllByCategoryAsync(int categoryId); //Kategoriye göre makale getirme
       
        Task<IDataResult<ArticleListDto>> GetAllByDeletedAsync(); //Tüm silinmis ögeleri getirme

        Task<IDataResult<ArticleListDto>> GetAllByViewCountAsync(bool isAscending, int? takeSize); //Siralama türüne ve kac tane makale almamiza göre getirecek. Mesala en cok okunan 6 makale gibi. Vermezsek hepsi gelir, verirsek istedigimiz kadar
       
        Task<IDataResult<ArticleListDto>> GetAllByPagingAsync(int? categroyId, int currentPage = 1, int pageSize = 6,
            bool isAscending = false); // Sayfalama islemleri icin kullaniliyor.

        //Task<IDataResult<ArticleListDto>> GetAllByUserIdOnFilter(int userId, FilterBy filterBy, OrderBy orderBy, bool isAscending, int takeSize, int categoryId, DateTime startAt, DateTime endAt, int minViewCount, int maxViewCount, int minCommentCount, int maxCommentCount);

        Task<IDataResult<ArticleListDto>> SearchAsync(string keyword, int currentPage = 1, int pageSize = 6, bool isAscending = false);

        Task<IResult> IncreaseViewCountAsync(int blogId);

        //Task<IDataResult<Article>> AddAsync(Category category, string createdByName);
        Task<IResult> AddAsync(ArticleAddDto articleAddDto, string createdByName);
       
        //Task<IDataResult<Article>> UpdateAsync(Category category, string modifiedByName);
        Task<IResult> UpdateAsync(ArticleUpdateDto articleUpdateDto, string modifiedByName);
        //Task<IDataResult<Article>> UpdateAsync(ArticleUpdateDto articleUpdateDto, string modifiedByName);
      
        Task<IResult> DeleteAsync(int articleId, string modifiedByName); // Silme islemi sadece IsDeleted degerini true yapar
        //Task<IDataResult<Article>> DeleteAsync(int articleId, string modifiedByName); // Silme islemi sadece IsDeleted degerini true yapar
       
        Task<IResult> UndoDeleteAsync(int articleId, string modifiedByName); // IsDeleted degeri true olanlari false yapar.
       
        Task<IResult> HardDeleteAsync(int articleId); // Degerleri Veritabanindan siler
       
        Task<IDataResult<int>> CountAsync();
       
        Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}
