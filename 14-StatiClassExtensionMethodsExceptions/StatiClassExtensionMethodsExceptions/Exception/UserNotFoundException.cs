using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatiClassExtensionMethodsExceptions.Exception
{
        public class UserNotFoundException : IOException
        {
            public UserNotFoundException()
                : base("Bele istifadeci tapilmadi.") 
            { 
            }

            public UserNotFoundException(string username)
                : base($"'{username}' adlı istifadeci tapılmadi.") 
            {  
            }
        }
    
}
