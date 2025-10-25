 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
     public string email class Person
     {
        public string FirstName;
        public string LastName;
        public int Age;
        public string Email;
         public string Id;

            
            public Person(string firstName, string lastName, int age, string email, string id)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Age = age;
                this.Email = email;
                this.Id = id;
            }

           
            public string GetFullName()
            {
                return $"{FirstName} {LastName}";
            }

            
            public void ShowBasicInfo()
            {
                Console.WriteLine($"Ad: {FirstName}", "Soyad: {LastName}", "Yaş: {Age}", "Email: {Email}", "ID: {Id}");

            }

public string ID;


     }
}
