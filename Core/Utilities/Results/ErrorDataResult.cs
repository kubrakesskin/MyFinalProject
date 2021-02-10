using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        //default dataya karşılık gelir.
        //data ve mesaj vermek isterse ctor + çift tab
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }

        //mesaj vermek istemezse (ctor+çift tab)
        public ErrorDataResult(T data) : base(data, false)
        {

        }
        //bir şey döndürmek istemez sadece mesaj vermek isterse (ctor+çift tab)
        public ErrorDataResult(string message) : base(default, false, message)
        {

        }
        //hic bir sey(ctor+çift tab)
        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
