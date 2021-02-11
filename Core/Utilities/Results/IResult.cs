using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidlar icin baslangic
   public interface IResult
    {
        //Islem Basarilimi, True or false - Success
        bool Success { get; }
        string Message { get; }
    }
}
