using System;
using System.Collections.Generic;
using System.Text;

namespace _0311hmw
{
    class InvalidUserNameException : Exception
    { public InvalidUserNameException(string message) : base(message)
        {

        }
    }
}
