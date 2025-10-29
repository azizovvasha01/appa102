using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatiClassExtensionMethodsExceptions.Exception
{
    public class IncorrectPasswordException : IOException
    {
        public int AttemptsLeft { get; }

        public IncorrectPasswordException(int attemptsLeft)
            : base($"Şifre yanlisdir! Qalan cehd sayi: {attemptsLeft}")
        {
            AttemptsLeft = attemptsLeft;
        }
    }
}
