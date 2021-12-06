using System.Collections.Generic;
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
        Task<IDataResult<CategoryDto>> GetAsync(int categoryId);
        
        Task<IDataResult<CategoryUpdateDto>> GetCategoryUpdateDtoAsync(int categoryId);
        
        Task<IDataResult<CategoryListDto>> GetAllAsync();
        //Task<IDataResult<Category>> GetAllAsync();
       
        Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAsync();
        //Task<IDataResult<Category>> GetAllByNonDeletedAsync();
        
        Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAndActiveAsync();
        
        Task<IDataResult<CategoryListDto>> GetAllByDeletedAsync(); //Tüm silinmis ögeleri getirme
        
        //Task<IDataResult<Category>> AddAsync(Category category, string createdByName);
        Task<IResult> AddAsync(CategoryAddDto categoryAddDto, string createdByName);
       
        //Task<IDataResult<Category>> UpdateAsync(Category category, string modifiedByName);
        Task<IResult> UpdateAsync(CategoryUpdateDto categoryUpdateDto, string modifiedByName);
        //Task<IDataResult<Category>> UpdateAsync(CategoryUpdateDto categoryUpdateDto, string modifiedByName);
        
        Task<IDataResult<CategoryDto>> DeleteAsync(int categoryId, string modifiedByName); // Silme islemi sadece IsDeleted degerini true yapar
        //Task<IDataResult<Category>> DeleteAsync(int categoryId, string modifiedByName); // Silme islemi sadece IsDeleted degerini true yapar
      
        Task<IDataResult<CategoryDto>> UndoDeleteAsync(int categoryId, string modifiedByName); // IsDeleted degeri true olanlari false yapar.
       
        Task<IResult> HardDeleteAsync(int categoryId); // Degerleri Veritabanindan siler
      
        Task<IDataResult<int>> CountAsync();
      
        Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}
