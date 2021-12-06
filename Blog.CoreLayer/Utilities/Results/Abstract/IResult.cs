﻿using System;
using System.Collections.Generic;
using Blog.CoreLayer.Entities.Concrete;
using Blog.CoreLayer.Utilities.Results.ComplexTypes;

namespace Blog.CoreLayer.Utilities.Results.Abstract
{
    public interface IResult
    {
        //Property'lere get vermemizin nedeni, constructor icerisinde bu bilgilerin verilmesindendir. Daha sonradan degistirilebilir olmamasi icin set parametreleri verilmez.
        public ResultStatus ResultStatus { get; } //ResultStatus.Success // ResultStatus.Error
        public string Message { get; }
        public Exception Exception { get; }

        public IEnumerable<ValidationError> ValidationErrors { get; set; } // ValidationErrors.Add --> Bu islem yapilamaz. Yani disaridan yenilemeyi IEnumerable ile kapatiliyor.
    }
}
