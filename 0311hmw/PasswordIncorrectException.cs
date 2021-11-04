using System;
using System.Collections.Generic;
using System.Text;

namespace _0311hmw
{
    class PasswordIncorrectException : Exception
    {
        public PasswordIncorrectException(string msj) : base (msj)
        {
            
        }

    }
}
