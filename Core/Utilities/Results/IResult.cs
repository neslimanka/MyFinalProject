using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    //Temel voidler için başlangıç
    public interface IResult
    {
        bool Success { get; } //sadece okunabilir. Set olsaydı yazılabilir demek olacaktı.
        string Message { get; }
    }
}
