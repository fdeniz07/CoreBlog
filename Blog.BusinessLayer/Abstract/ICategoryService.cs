using System.Threading.Tasks;
using Blog.CoreLayer.Utilities.Results.Abstract;
using Blog.EntityLayer.Concrete;
using Blog.EntityLayer.Dtos;

namespace Blog.BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        //Metotlarimizi simdilik Entity'ler üzerinden yapacagiz. Ileri de bu Entity alanlarini kuracagimiz DTO'lar ile degistirecegiz.

        //DTO : Data Transfer Object anlamina gelen, Frontend tarafinda kullanicinin ihtiyac duyacagi ilgili entity'lere ait property'leri tutar.
        Task<IDataResult<Category>> GetAsync(int categoryId);
        Task<IDataResult<Category>> GetCategoryUpdateDtoAsync(int categoryId);
        Task<IDataResult<Category>> GetAllAsync();
        Task<IDataResult<Category>> GetAllByNonDeletedAsync();
        Task<IDataResult<Category>> GetAllByNonDeletedAndActiveAsync();
        Task<IDataResult<Category>> GetAllByDeletedAsync(); //Tüm silinmis ögeleri getirme
        //Task<IDataResult<Category>> AddAsync(Category category, string createdByName);
        Task<IDataResult<Category>> AddAsync(CategoryAddDto categoryAddDto, string createdByName);
        //Task<IDataResult<Category>> UpdateAsync(Category category, string modifiedByName);
        Task<IDataResult<Category>> UpdateAsync(CategoryUpdateDto categoryUpdateDto, string modifiedByName);
        Task<IDataResult<Category>> DeleteAsync(int categoryId, string modifiedByName); // Silme islemi sadece IsDeleted degerini true yapar
        Task<IDataResult<Category>> UndoDeleteAsync(int categoryId, string modifiedByName); // IsDeleted degeri true olanlari false yapar.
        Task<IResult> HardDeleteAsync(int categoryId); // Degerleri Veritabanindan siler
        Task<IDataResult<int>> CountAsync();
        Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}
