using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class Result : IResult
    {
        public Result(bool success, string message) : this(success)
        //C# ta this demek classın kendısı demektir.
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
