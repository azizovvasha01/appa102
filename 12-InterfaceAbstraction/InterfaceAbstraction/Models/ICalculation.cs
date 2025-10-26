using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstraction.Models
{
    internal interface ICalculation
    {
        public string Number1 {  get; set; }
        public string Number2 { get; set; }
        public string Answer { get; set; }

        void ShowAnswer();
    };
}
