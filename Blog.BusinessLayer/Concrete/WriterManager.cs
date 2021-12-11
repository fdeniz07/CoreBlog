using AutoMapper;
using Blog.BusinessLayer.Abstract;
using Blog.BusinessLayer.Utilities;
using Blog.CoreLayer.Utilities.Results.Abstract;
using Blog.CoreLayer.Utilities.Results.ComplexTypes;
using Blog.CoreLayer.Utilities.Results.Concrete;
using Blog.DataAccessLayer.Abstract.UnitOfWorks;
using Blog.EntityLayer.Concrete;
using Blog.EntityLayer.Dtos;
using System.Threading.Tasks;

namespace Blog.BusinessLayer.Concrete
{
    public class WriterManager:ManagerBase,IWriterService
    {
        public WriterManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }


        /////////////////////// GetAsync \\\\\\\\\\\\\\\\\\\\\\\\\\\\

        public async Task<IDataResult<WriterDto>> GetAsync(int writerId)
        {
            var writer = await UnitOfWork.Writers.GetAsync(w => w.Id == writerId, w => w.Articles);
            if (writer != null)
            {
                return new DataResult<WriterDto>(ResultStatus.Success, new WriterDto
                {
                    Writer = writer,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<WriterDto>(ResultStatus.Error, Messages.Writer.NotFound(isPlural: false), null);
        }


        /////////////////////// GetWriterUpdateDtoAsync \\\\\\\\\\\\\\\\\\\\\\\\\\\\

        public async Task<IDataResult<WriterUpdateDto>> GetWriterUpdateDtoAsync(int writerId)
        {
            throw new System.NotImplementedException();
        }


        /////////////////////// AddAsync \\\\\\\\\\\\\\\\\\\\\\\\\\\\

        public async  Task<IResult> AddAsync(WriterAddDto writerAddDto)
        {
            var writer = Mapper.Map<Writer>(writerAddDto);
            await UnitOfWork.Writers.AddAsync(writer);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, Messages.Writer.Add(writer.UserName));
        }


        /////////////////////// UpdateAsync \\\\\\\\\\\\\\\\\\\\\\\\\\\\

        public async Task<IResult> UpdateAsync(WriterUpdateDto writerUpdateDto)
        {
            var oldWriter = await UnitOfWork.Writers.GetAsync(b => b.Id == writerUpdateDto.Id);
            var writer = Mapper.Map<WriterUpdateDto, Writer>(writerUpdateDto, oldWriter);
            await UnitOfWork.Writers.UpdateAsync(writer);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, Messages.Writer.Update(writer.UserName));
        }


        /////////////////////// DeleteAsync \\\\\\\\\\\\\\\\\\\\\\\\\\\\

        public async Task<IResult> DeleteAsync(int writerId)
        {
            var result = await UnitOfWork.Writers.AnyAsync(u => u.Id == writerId);
            if (result)
            {
                var writer = await UnitOfWork.Writers.GetAsync(u => u.Id == writerId);
                await UnitOfWork.Writers.UpdateAsync(writer);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.Writer.Delete(writer.UserName));
            }
            return new Result(ResultStatus.Error, Messages.Writer.NotFound(isPlural: false));
        }


        /////////////////////// HardDeleteAsync \\\\\\\\\\\\\\\\\\\\\\\\\\\\

        public async Task<IResult> HardDeleteAsync(int writerId)
        {
            var result = await UnitOfWork.Writers.AnyAsync(u => u.Id == writerId);
            if (result)
            {
                var writer = await UnitOfWork.Writers.GetAsync(u => u.Id == writerId);
                await UnitOfWork.Writers.DeleteAsync(writer);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.Writer.HardDelete(writer.UserName));
            }
            return new Result(ResultStatus.Error, Messages.Writer.NotFound(isPlural: false));
        }


        /////////////////////// UndoDeleteAsync \\\\\\\\\\\\\\\\\\\\\\\\\\\\ Silinmisleri Geri Al

        public async Task<IResult> UndoDeleteAsync(int writerId)
        {
            var result = await UnitOfWork.Writers.AnyAsync(u => u.Id == writerId);
            if (result)
            {
                var writer = await UnitOfWork.Writers.GetAsync(u => u.Id == writerId);
                await UnitOfWork.Writers.UpdateAsync(writer);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.Writer.UndoDelete(writer.UserName));
            }
            return new Result(ResultStatus.Error, Messages.Writer.NotFound(isPlural: false));
        }
    }
}
