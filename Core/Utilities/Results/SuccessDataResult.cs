using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        //default dataya karşılık gelir.
        //data ve mesaj vermek isterse ctor + çift tab
        public SuccessDataResult(T data, string message):base(data,true,message)
        {
               
        }

        //mesaj vermek istemezse (ctor+çift tab)
        public SuccessDataResult(T data): base(data,true)
        {

        }
        //bir şey döndürmek istemez sadece mesaj vermek isterse (ctor+çift tab)
        public SuccessDataResult(string message):base(default, true, message)
        {

        }
        //hic bir sey(ctor+çift tab)
        public SuccessDataResult():base(default, true)
        {

        }
    }
}
