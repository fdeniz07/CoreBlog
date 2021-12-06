using Blog.BusinessLayer.Abstract;
using Blog.CoreLayer.Utilities.Results.Abstract;
using System;
using System.Threading.Tasks;
using Blog.EntityLayer.Dtos;

namespace Blog.BusinessLayer.Concrete
{
    public class CommentManager:ICommentService
    {
        #region Implementation of ICommentService

        public Task<IDataResult<CommentDto>> GetAsync(int commentId)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<CommentUpdateDto>> GetCommentUpdateDtoAsync(int commentId)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<CommentListDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<CommentListDto>> GetAllByDeletedAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<CommentListDto>> GetAllByNonDeletedAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<CommentListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<CommentDto>> ApproveAsync(int commentId, string modifiedByName)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<CommentDto>> AddAsync(CommentAddDto commentAddDto)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<CommentDto>> UpdateAsync(CommentUpdateDto commentUpdateDto, string modifiedByName)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<CommentDto>> DeleteAsync(int commentId, string modifiedByName)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<CommentDto>> UndoDeleteAsync(int commentId, string modifiedByName)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> HardDeleteAsync(int commentId)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<int>> CountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<int>> CountByNonDeletedAsync()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
