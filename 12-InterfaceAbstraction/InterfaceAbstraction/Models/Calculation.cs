using InterfaceAbstraction.Models;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstraction.Models
{
    
    
}
internal class Calculation : ICalculation
{
    private bool isValid;

    public string Number1 { get; set; }
    public string Number2 { get; set; }
    public string Answer { get; set; }

    public void ShowAnswer() => Console.WriteLine($"Number1 : {Number1}\nNumber2 : {Number2}\nAnswer  : {ShowAnswer}");

   

    internal void CreateCalucation()
    {
        Console.Write("Number1: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Number2: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Emeliyyat seç (+, -, *, /): ");
        string operation = Console.ReadLine();

        

        double result = 0;
        isValid = true;

        if (operation == "+")
        {
            result = number1 + number2;
        }
        else if (operation == "-")
        {
            result = number1 - number2;
        }
        else if (operation == "*")
        {
            result = number1 * number2;
        }
        else if (operation == "/")
        {
            if (number2 == 0)
            {
                Console.WriteLine("Bolmede sifir olmaz!");
                isValid = false;
            }
            else
            {
                result = (double)number1 / number2;
            }
        }
        else
        {
            Console.WriteLine("Hatali islem!");
            isValid = false;
        }

        if (isValid)
        {
            Number1 = number1.ToString();
            Number2 = number2.ToString();
            Answer = result.ToString();
            ShowAnswer();
        }
    }
}


