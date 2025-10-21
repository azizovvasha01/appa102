using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Car
    {
        public string _name;
        private int _horsePower;


        public int HorsePower 
        { 
            get
            {
               if (_horsePower < 100)
               {
                    Console.WriteLine("can't");
                    return -1;
               }
                return _horsePower;
                

            }

            
            set
            {
                if (value > 300)
                {
                    Console.WriteLine("Please enter valid power");
                    return;
                }
                _horsePower = value;
            }
        }
    }
}
