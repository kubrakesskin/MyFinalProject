using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult //IResults'ın somut hali
    {

        public Result(bool success, string message):this(success)
        //iki parametre gönderildiginde this diyerek bu parametreyi çalıştır dedik
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }



 
    }
}
