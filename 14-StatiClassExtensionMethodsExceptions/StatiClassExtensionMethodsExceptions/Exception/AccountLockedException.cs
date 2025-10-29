using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatiClassExtensionMethodsExceptions.Exception
{
        public class AccountLockedException : IOException
        {
            public AccountLockedException()
                : base("Hesab bloklanib. Zehmet olmasa administratorla elaqe saxlayin.") 
            { 
            }
        }
    
}
