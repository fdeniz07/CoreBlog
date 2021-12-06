using Blog.BusinessLayer.Abstract;
using Blog.CoreLayer.Utilities.Results.Abstract;
using Blog.CoreLayer.Utilities.Results.ComplexTypes;
using Blog.CoreLayer.Utilities.Results.Concrete;
using Blog.DataAccessLayer.Abstract.UnitOfWorks;
using Blog.EntityLayer.Concrete;
using Blog.EntityLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Blog.BusinessLayer.Utilities;

namespace Blog.BusinessLayer.Concrete
{
    public class CategoryManager :ManagerBase, ICategoryService
    {
        public CategoryManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }


        #region Implementation of ICategoryService

        /////////////////////// GetAsync \\\\\\\\\\\\\\\\\\\\\\\\\\\\

        public async Task<IDataResult<CategoryDto>> GetAsync(int categoryId)
        {
            var category = await UnitOfWork.Categories.GetAsync(c => c.Id == categoryId, c => c.Articles);
            if (category != null)
            {
                return new DataResult<CategoryDto>(ResultStatus.Success, new CategoryDto
                {
                    Category = category,
                    ResultStatus = ResultStatus.Success
                });
            }

            return new DataResult<CategoryDto>(ResultStatus.Error, Messages.Category.NotFound(isPlural: false), new CategoryDto
            {
                Category = null,
                ResultStatus = ResultStatus.Error,
                Message = Messages.Category.NotFound(isPlural: false)
            });
        }

        //public async Task<IDataResult<CategoryDto>> GetAsync(int categoryId)
        //{
        //    var category = await UnitOfWork.Categories.GetAsync(c => c.Id == categoryId, c => c.Articles);
        //    if (category != null)
        //    {
        //        return new DataResult<CategoryDto>(ResultStatus.Success, category);
        //    }

        //    return new DataResult<CategoryDto>(ResultStatus.Error, "Böyle bir kategori bulunamadı.", null);
        //}


        /////////////////////// GetCategoryUpdateDtoAsync \\\\\\\\\\\\\\\\\\\\\\\\\\\\

        public async Task<IDataResult<CategoryUpdateDto>> GetCategoryUpdateDtoAsync(int categoryId)
        {
            var result = await UnitOfWork.Categories.AnyAsync(c => c.Id == categoryId);
            if (result)
            {
                var category = await UnitOfWork.Categories.GetAsync(c => c.Id == categoryId);
                var categoryUpdateDto = Mapper.Map<CategoryUpdateDto>(category);
                return new DataResult<CategoryUpdateDto>(ResultStatus.Success, categoryUpdateDto);
            }
            else
            {
                return new DataResult<CategoryUpdateDto>(ResultStatus.Error, Messages.Category.NotFound(isPlural: false), null);
            }
        }


        /////////////////////// GetAllAsync \\\\\\\\\\\\\\\\\\\\\\\\\\\\

        public async Task<IDataResult<CategoryListDto>> GetAllAsync()
        {
            var categories = await UnitOfWork.Categories.GetAllAsync(null, c => c.Articles);
            if (categories.Count > -1) //Hic kategorisi de olmayabilir. O yüzden 0 yerine -1 yaziyoruz
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto
                {
                    Categories = categories,
                    ResultStatus = ResultStatus.Success
                });
            }

            return new DataResult<CategoryListDto>(ResultStatus.Error, Messages.Category.NotFound(isPlural: false), new CategoryListDto
            {
                Categories = null,
                ResultStatus = ResultStatus.Error,
                Message = Messages.Category.NotFound(isPlural: true)
            });
        }

        //public async Task<IDataResult<Category>> GetAllAsync()
        //{
        //    var categories = await UnitOfWork.Categories.GetAllAsync(null, c => c.Articles);
        //    if (categories.Count > -1) //Hic kategorisi de olmayabilir. O yüzden 0 yerine -1 yaziyoruz
        //    {
        //        return new DataResult<IList<Category>>(ResultStatus.Success, categories);
        //    }

        //    return new DataResult<IList<Category>>(ResultStatus.Error, "Hiç bir kategori bulunamadı.", null);
        //}



        /////////////////////// GetAllByNonDeletedAsync \\\\\\\\\\\\\\\\\\\\\\\\\\\\

        public async Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAsync() //Silinmemis olanlari getir
        {
            var categories = await UnitOfWork.Categories.GetAllAsync(c => !c.IsDeleted, c => c.Articles);
            if (categories.Count > -1) //Hic kategorisi de olmayabilir. O yüzden 0 yerine -1 yaziyoruz
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto
                {
                    Categories = categories,
                    ResultStatus = ResultStatus.Success
                });
            }

            return new DataResult<CategoryListDto>(ResultStatus.Error, Messages.Category.NotFound(isPlural: true), new CategoryListDto
            {
                Categories = null,
                ResultStatus = ResultStatus.Error,
                Message = Messages.Category.NotFound(isPlural: true)
            });
        }

        //public async Task<IDataResult<IList<Category>>> GetAllByNonDeletedAsync() //Silinmemis olanlari getir
        //{
        //    var categories = await UnitOfWork.Categories.GetAllAsync(c => !c.IsDeleted, c => c.Articles);
        //    if (categories.Count > -1) //Hic kategorisi de olmayabilir. O yüzden 0 yerine -1 yaziyoruz
        //    {
        //        return new DataResult<IList<Category>>(ResultStatus.Success, categories);
        //    }

        //    return new DataResult<IList<Category>>(ResultStatus.Error, "Hiç bir kategori bulunamadı.", null);
        //}


        /////////////////////// GetAllByNonDeletedAndActiveAsync \\\\\\\\\\\\\\\\\\\\\\\\\\\\

        public async Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var categories = await UnitOfWork.Categories.GetAllAsync(c => !c.IsDeleted && c.IsActive);
            if (categories.Count > -1) //Hic kategorisi de olmayabilir. O yüzden 0 yerine -1 yaziyoruz
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto
                {
                    Categories = categories,
                    ResultStatus = ResultStatus.Success
                });
            }

            return new DataResult<CategoryListDto>(ResultStatus.Error, Messages.Category.NotFound(isPlural: true), null);
        }


        /////////////////////// GetAllByDeletedAsync \\\\\\\\\\\\\\\\\\\\\\\\\\\\ Silinmisleri Getir

        public async Task<IDataResult<CategoryListDto>> GetAllByDeletedAsync()
        {
            var categories = await UnitOfWork.Categories.GetAllAsync(c => !c.IsDeleted);
            if (categories.Count > -1) //Hic kategorisi de olmayabilir. O yüzden 0 yerine -1 yaziyoruz
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto
                {
                    Categories = categories,
                    ResultStatus = ResultStatus.Success
                });
            }

            return new DataResult<CategoryListDto>(ResultStatus.Error, Messages.Category.NotFound(isPlural: true), null);
        }


        /////////////////////// AddAsync \\\\\\\\\\\\\\\\\\\\\\\\\\\\

        public async Task<IResult> AddAsync(CategoryAddDto categoryAddDto, string createdByName)
        {
            #region Before using Automapper
            //await _unitOfWork.Categories.AddAsync(new Category
            //{
            //    Name = categoryAddDto.Name,
            //    Description = categoryAddDto.Description,
            //    Note = categoryAddDto.Note,
            //    IsActive = categoryAddDto.IsActive,
            //    CreatedByName = createdByName,
            //    CreatedDate = DateTime.Now,
            //    ModifiedByName = createdByName,
            //    ModifiedDate = DateTime.Now,
            //    IsDeleted = false
            //}).ContinueWith(t => _unitOfWork.SaveAsync());
            ////ContinueWith den itibaren zincirleme task islemini devam ettiriyoruz. Kayit daha tamamlanmadan asagidaki result kismina gecer. Cok performansli bir yapi olmasina karsi yönetimi biraz daha zor bir yapidir. JQuery / Ajax yapisina uygundur.
            ////await _unitOfWork.SaveAsync();
            #endregion

            //After using Automapper
            var category = Mapper.Map<Category>(categoryAddDto);
            category.CreatedByName = createdByName;
            category.ModifiedByName = createdByName;
            var addedCategory = await UnitOfWork.Categories.AddAsync(category);
            await UnitOfWork.SaveAsync();

            return new DataResult<CategoryDto>(ResultStatus.Success, Messages.Category.Add(addedCategory.Name), new CategoryDto
            {
                Category = addedCategory,
                ResultStatus = ResultStatus.Success,
                Message = Messages.Category.Add(addedCategory.Name)
            });
        }


        /////////////////////// UpdateAsync \\\\\\\\\\\\\\\\\\\\\\\\\\\\

        public async Task<IResult> UpdateAsync(CategoryUpdateDto categoryUpdateDto, string modifiedByName)
        {
            #region Before using Automapper
            //var category = await UnitOfWork.Categories.GetAsync(c => c.Id == categoryUpdateDto.Id);
            //if (category != null)
            //{
            //    category.Name = categoryUpdateDto.Name;
            //    category.Description = categoryUpdateDto.Description;
            //    category.Note = categoryUpdateDto.Note;
            //    category.IsActive = categoryUpdateDto.IsActive;
            //    category.IsDeleted = categoryUpdateDto.IsDeleted;
            //    category.ModifiedByName = modifiedByName;
            //    category.ModifiedDate = DateTime.Now;
            //    await UnitOfWork.Categories.UpdateAsync(category).ContinueWith(t => _unitOfWork.SaveAsync());
            //    return new Result(ResultStatus.Success, $"{categoryUpdateDto.Name} adli kategori basariyla güncellenmistir.");
            //}
            #endregion
            //After using Automapper
            var oldCategory = await UnitOfWork.Categories.GetAsync(c => c.Id == categoryUpdateDto.Id);
            var category = Mapper.Map<CategoryUpdateDto, Category>(categoryUpdateDto, oldCategory);
            category.ModifiedByName = modifiedByName;

            var updatedCategory = await UnitOfWork.Categories.UpdateAsync(category);
            await UnitOfWork.SaveAsync();
            return new DataResult<CategoryDto>(ResultStatus.Success, Messages.Category.Update(updatedCategory.Name), new CategoryDto
            {
                Category = updatedCategory,
                ResultStatus = ResultStatus.Success,
                Message = Messages.Category.Update(updatedCategory.Name)
            });
        }


        /////////////////////// DeleteAsync \\\\\\\\\\\\\\\\\\\\\\\\\\\\

        public async Task<IDataResult<CategoryDto>> DeleteAsync(int categoryId, string modifiedByName)
        {
            //var category = await UnitOfWork.Categories.GetAsync(c => c.Id == categoryId);
            //if (category != null)
            //{
            //    category.IsDeleted = false;
            //    category.ModifiedByName = modifiedByName;
            //    category.ModifiedDate = DateTime.Now;
            //    await UnitOfWork.Categories.UpdateAsync(category).ContinueWith(t => _unitOfWork.SaveAsync());
            //    return new Result(ResultStatus.Success, $"{category.Name} adli kategori basariyla silinmistir.");
            //}
            //return new Result(ResultStatus.Error, "Hiç bir kategori bulunamadı.", null);

            var category = await UnitOfWork.Categories.GetAsync(c => c.Id == categoryId);

            if (category != null)
            {
                category.IsDeleted = true;
                category.IsActive = false;
                category.ModifiedByName = modifiedByName;
                category.ModifiedDate = DateTime.Now;

                var deletedCategory = await UnitOfWork.Categories.UpdateAsync(category);
                await UnitOfWork.SaveAsync();
                return new DataResult<CategoryDto>(ResultStatus.Success, Messages.Category.Delete(deletedCategory.Name),
                    new CategoryDto
                    {
                        Category = deletedCategory,
                        ResultStatus = ResultStatus.Success,
                        Message = Messages.Category.Delete(deletedCategory.Name)
                    });
            }

            return new DataResult<CategoryDto>(ResultStatus.Error, Messages.Category.NotFound(isPlural: false), new CategoryDto
                {
                    Category = null,
                    ResultStatus = ResultStatus.Error,
                    Message = Messages.Category.NotFound(isPlural: false)
                });
        }


        /////////////////////// UndoDeleteAsync \\\\\\\\\\\\\\\\\\\\\\\\\\\\

        public async Task<IDataResult<CategoryDto>> UndoDeleteAsync(int categoryId, string modifiedByName)
        {
            var category = await UnitOfWork.Categories.GetAsync(c => c.Id == categoryId);

            if (category != null)
            {
                category.IsDeleted = false;
                category.IsActive = true;
                category.ModifiedByName = modifiedByName;
                category.ModifiedDate = DateTime.Now;

                var deletedCategory = await UnitOfWork.Categories.UpdateAsync(category);
                await UnitOfWork.SaveAsync();
                return new DataResult<CategoryDto>(ResultStatus.Success, Messages.Category.UndoDelete(deletedCategory.Name), new CategoryDto
                {
                    Category = deletedCategory,
                    ResultStatus = ResultStatus.Success,
                    Message = Messages.Category.UndoDelete(deletedCategory.Name)
                });
            }
            return new DataResult<CategoryDto>(ResultStatus.Error, Messages.Category.NotFound(isPlural: false), new CategoryDto
            {
                Category = null,
                ResultStatus = ResultStatus.Error,
                Message = Messages.Category.NotFound(isPlural: false)
            });
        }


        /////////////////////// HardDeleteAsync \\\\\\\\\\\\\\\\\\\\\\\\\\\\

        public async Task<IResult> HardDeleteAsync(int categoryId)
        {
            //var category = await UnitOfWork.Categories.GetAsync(c => c.Id == categoryId);
            //if (category != null)
            //{
            //    await UnitOfWork.Categories.DeleteAsync(category).ContinueWith(t => _unitOfWork.SaveAsync());
            //    return new Result(ResultStatus.Success, $"{category.Name} adlı kategori veritabanindan başarıyla silinmiştir.");
            //}
            //return new Result(ResultStatus.Error, "Hiç bir kategori bulunamadı.", null);

            var category = await UnitOfWork.Categories.GetAsync(c => c.Id == categoryId);

            if (category != null)
            {
                await UnitOfWork.Categories.DeleteAsync(category);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.Category.HardDelete(category.Name));
            }
            return new Result(ResultStatus.Error, Messages.Category.NotFound(isPlural: false));
        }



        /////////////////////// CountAsync \\\\\\\\\\\\\\\\\\\\\\\\\\\\

        public async Task<IDataResult<int>> CountAsync()
        {

            var categoriesCount = await UnitOfWork.Categories.CountAsync();// tüm degerleri getir
            if (categoriesCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, categoriesCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, $"Beklenmeyen bir hata ile karşılaşıldı.", -1);
            }
        }


        /////////////////////// CountByNonDeletedAsync \\\\\\\\\\\\\\\\\\\\\\\\\\\\

        public async Task<IDataResult<int>> CountByNonDeletedAsync()
        {
            var categoriesCount = await UnitOfWork.Categories.CountAsync(c => !c.IsDeleted);// Silinmemis degerleri getir
            if (categoriesCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, categoriesCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, $"Beklenmeyen bir hata ile karşılaşıldı.", -1);
            }
        }

        #endregion
    }
}
