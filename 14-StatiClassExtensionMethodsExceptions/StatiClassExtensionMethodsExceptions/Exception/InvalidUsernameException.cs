using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatiClassExtensionMethodsExceptions.Exception
{
    public class InvalidUsernameException : IOException
    {
        public InvalidUsernameException()
            : base("Username boş ola bilmez ve min 3 simvol olmalıdır.")
        {

        }
        public InvalidUsernameException(string message)
            : base(message)
        {

        }
    }

}

