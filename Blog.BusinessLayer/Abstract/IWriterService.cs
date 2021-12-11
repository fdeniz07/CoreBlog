using System.Threading.Tasks;
using Blog.CoreLayer.Utilities.Results.Abstract;
using Blog.EntityLayer.Dtos;

namespace Blog.BusinessLayer.Abstract
{
    public interface IWriterService
    {
        Task<IDataResult<WriterDto>> GetAsync(int writerId);
        Task<IDataResult<WriterUpdateDto>> GetWriterUpdateDtoAsync(int writerId);
        Task<IResult> AddAsync(WriterAddDto writerAddDto);
        Task<IResult> UpdateAsync(WriterUpdateDto writerUpdateDto);
        Task<IResult> DeleteAsync(int writerId);
        Task<IResult> UndoDeleteAsync(int writerId);
        Task<IResult> HardDeleteAsync(int writerId);
    }
}
