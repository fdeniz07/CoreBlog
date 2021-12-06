using Blog.CoreLayer.Utilities.Results.ComplexTypes;

namespace Blog.CoreLayer.Entities.Abstract
{
    public abstract class DtoGetBase
    {
        public virtual ResultStatus ResultStatus { get; set; } // Burada ResultStatus dönmemizin nedeni Frontend tarafindan jquery ajax kullanirsak orada da sonuc kümesi dönmek isteyebiliriz
    }
}
