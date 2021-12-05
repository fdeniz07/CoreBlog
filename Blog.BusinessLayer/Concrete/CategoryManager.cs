using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blog.BusinessLayer.Abstract;
using Blog.CoreLayer.Utilities.Results.Abstract;
using Blog.CoreLayer.Utilities.Results.ComplexTypes;
using Blog.CoreLayer.Utilities.Results.Concrete;
using Blog.DataAccessLayer.Abstract.UnitOfWorks;
using Blog.DataAccessLayer.Concrete.UnitOfWork;
using Blog.EntityLayer.Concrete;
using Blog.EntityLayer.Dtos;

namespace Blog.BusinessLayer.Concrete
{
    public class CategoryManager:ICategoryService
    {

        private readonly IUnitOfWork _unitOfWork; //DI ile unitOfWork yapimizi enjekte ediyoruz

        public CategoryManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        #region Implementation of ICategoryService

        /////////////////////// GetAsync \\\\\\\\\\\\\\\\\\\\\\\\\\\\

        public async Task<IDataResult<Category>> GetAsync(int categoryId)
        {
            var category = await _unitOfWork.Categories.GetAsync(c => c.Id == categoryId, c => c.Articles);
            if (category!=null)
            {
                return new DataResult<Category>(ResultStatus.Success, category);
            }

            return new DataResult<Category>(ResultStatus.Error, "Böyle bir kategori bulunamadı.", null);
        }

        public Task<IDataResult<Category>> GetCategoryUpdateDtoAsync(int categoryId)
        {
            throw new System.NotImplementedException();
        }


        /////////////////////// GetAllAsync \\\\\\\\\\\\\\\\\\\\\\\\\\\\

        public async Task<IDataResult<IList<Category>>> GetAllAsync()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync(null,c=>c.Articles);
            if (categories.Count > -1) //Hic kategorisi de olmayabilir. O yüzden 0 yerine -1 yaziyoruz
            {
                return new DataResult<IList<Category>>(ResultStatus.Success, categories);
            }

            return new DataResult<IList<Category>>(ResultStatus.Error, "Hiç bir kategori bulunamadı.",null);
        }


        /////////////////////// GetAllByNonDeletedAsync \\\\\\\\\\\\\\\\\\\\\\\\\\\\

        public async  Task<IDataResult<IList<Category>>> GetAllByNonDeletedAsync() //Silinmemis olanlari getir
        {
            var categories = await _unitOfWork.Categories.GetAllAsync(c => !c.IsDeleted,c=>c.Articles);
            if (categories.Count > -1) //Hic kategorisi de olmayabilir. O yüzden 0 yerine -1 yaziyoruz
            {
                return new DataResult<IList<Category>>(ResultStatus.Success, categories);
            }

            return new DataResult<IList<Category>>(ResultStatus.Error, "Hiç bir kategori bulunamadı.", null);
        }


        /////////////////////// GetAllByNonDeletedAndActiveAsync \\\\\\\\\\\\\\\\\\\\\\\\\\\\

        public Task<IDataResult<Category>> GetAllByNonDeletedAndActiveAsync()
        {
            throw new System.NotImplementedException();
        }


        /////////////////////// GetAllByDeletedAsync \\\\\\\\\\\\\\\\\\\\\\\\\\\\ Silinmisleri Getir

        public Task<IDataResult<Category>> GetAllByDeletedAsync()
        {
            throw new System.NotImplementedException();
        }


        /////////////////////// AddAsync \\\\\\\\\\\\\\\\\\\\\\\\\\\\

        public async Task<IResult> AddAsync(CategoryAddDto categoryAddDto, string createdByName)
        {
            await _unitOfWork.Categories.AddAsync(new Category
            {
                Name = categoryAddDto.Name,
                Description = categoryAddDto.Description,
                Note = categoryAddDto.Note,
                IsActive = categoryAddDto.IsActive,
                CreatedByName = createdByName,
                CreatedDate = DateTime.Now,
                ModifiedByName = createdByName,
                ModifiedDate = DateTime.Now,
                IsDeleted = false
            }).ContinueWith(t => _unitOfWork.SaveAsync());
            //ContinueWith den itibaren zincirleme task islemini devam ettiriyoruz. Kayit daha tamamlanmadan asagidaki result kismina gecer. Cok performansli bir yapi olmasina karsi yönetimi biraz daha zor bir yapidir. JQuery / Ajax yapisina uygundur.
            //await _unitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, $"{categoryAddDto.Name} adlı kategori başarıyla eklenmiştir.");
        }


        /////////////////////// UpdateAsync \\\\\\\\\\\\\\\\\\\\\\\\\\\\

        public async Task<IResult> UpdateAsync(CategoryUpdateDto categoryUpdateDto, string modifiedByName)
        {
            var category = await _unitOfWork.Categories.GetAsync(c => c.Id == categoryUpdateDto.Id);
            if (category != null)
            {
                category.Name = categoryUpdateDto.Name;
                category.Description = categoryUpdateDto.Description;
                category.Note = categoryUpdateDto.Note;
                category.IsActive = categoryUpdateDto.IsActive;
                category.IsDeleted = categoryUpdateDto.IsDeleted;
                category.ModifiedByName = modifiedByName;
                category.ModifiedDate = DateTime.Now;
                await _unitOfWork.Categories.UpdateAsync(category).ContinueWith(t => _unitOfWork.SaveAsync());
                return new Result(ResultStatus.Success, $"{categoryUpdateDto.Name} adli kategori basariyla güncellenmistir.");
            }
            return new Result(ResultStatus.Error, "Hiç bir kategori bulunamadı.", null);
        }


        /////////////////////// DeleteAsync \\\\\\\\\\\\\\\\\\\\\\\\\\\\

        public async Task<IResult> DeleteAsync(int categoryId, string modifiedByName)
        {
            var category = await _unitOfWork.Categories.GetAsync(c => c.Id == categoryId);
            if (category != null)
            {
                category.IsDeleted = false;
                category.ModifiedByName = modifiedByName;
                category.ModifiedDate = DateTime.Now;
                await _unitOfWork.Categories.UpdateAsync(category).ContinueWith(t => _unitOfWork.SaveAsync());
                return new Result(ResultStatus.Success, $"{category.Name} adli kategori basariyla silinmistir.");
            }
            return new Result(ResultStatus.Error, "Hiç bir kategori bulunamadı.", null);
        }


        /////////////////////// UndoDeleteAsync \\\\\\\\\\\\\\\\\\\\\\\\\\\\

        public Task<IDataResult<Category>> UndoDeleteAsync(int categoryId, string modifiedByName)
        {
            throw new System.NotImplementedException();
        }


        /////////////////////// HardDeleteAsync \\\\\\\\\\\\\\\\\\\\\\\\\\\\

        public async  Task<IResult> HardDeleteAsync(int categoryId)
        {
            var category = await _unitOfWork.Categories.GetAsync(c => c.Id == categoryId);
            if (category != null)
            {
                await _unitOfWork.Categories.DeleteAsync(category).ContinueWith(t => _unitOfWork.SaveAsync());
                return new Result(ResultStatus.Success, $"{category.Name} adlı kategori veritabanindan başarıyla silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Hiç bir kategori bulunamadı.", null);
        }
    


        /////////////////////// CountAsync \\\\\\\\\\\\\\\\\\\\\\\\\\\\

        public Task<IDataResult<int>> CountAsync()
        {
            throw new System.NotImplementedException();
        }


        /////////////////////// CountByNonDeletedAsync \\\\\\\\\\\\\\\\\\\\\\\\\\\\

        public Task<IDataResult<int>> CountByNonDeletedAsync()
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
