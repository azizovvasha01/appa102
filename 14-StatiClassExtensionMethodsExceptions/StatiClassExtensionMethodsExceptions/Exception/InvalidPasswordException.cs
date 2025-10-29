using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatiClassExtensionMethodsExceptions.Exception
{
    public class InvalidPasswordException : IOException
    {
        public InvalidPasswordException()
            : base("Password boş ola bilmez ve min 6 simvol olmalidir.") 
        { 
        }

        public InvalidPasswordException(string message)
            : base(message) 
        { 
        }
    }

}
