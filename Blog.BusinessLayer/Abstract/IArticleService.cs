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
        Task<IDataResult<Article>> GetAsync(int articleId);
        Task<IDataResult<Article>> GetArticleUpdateDtoAsync(int articleId);
        Task<IDataResult<IList<Article>>> GetAllAsync();
        //Task<IDataResult<Article>> GetAllAsync();
        Task<IDataResult<IList<Article>>> GetAllByNonDeletedAsync();
        //Task<IDataResult<Article>> GetAllByNonDeletedAsync();
        Task<IDataResult<Article>> GetAllByNonDeletedAndActiveAsync();
        Task<IDataResult<Article>> GetAllByDeletedAsync(); //Tüm silinmis ögeleri getirme
        //Task<IDataResult<Article>> AddAsync(Category category, string createdByName);
        Task<IResult> AddAsync(ArticleAddDto articleAddDto, string createdByName);
        //Task<IDataResult<Article>> UpdateAsync(Category category, string modifiedByName);
        Task<IResult> UpdateAsync(ArticleUpdateDto articleUpdateDto, string modifiedByName);
        //Task<IDataResult<Article>> UpdateAsync(ArticleUpdateDto articleUpdateDto, string modifiedByName);
        Task<IResult> DeleteAsync(int articleId, string modifiedByName); // Silme islemi sadece IsDeleted degerini true yapar
        //Task<IDataResult<Article>> DeleteAsync(int articleId, string modifiedByName); // Silme islemi sadece IsDeleted degerini true yapar
        Task<IDataResult<Article>> UndoDeleteAsync(int articleId, string modifiedByName); // IsDeleted degeri true olanlari false yapar.
        Task<IResult> HardDeleteAsync(int articleId); // Degerleri Veritabanindan siler
        Task<IDataResult<int>> CountAsync();
        Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}
