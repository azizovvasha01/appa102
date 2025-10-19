using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models;

 class Teacher : Person
 {

    public string Department;
    public string MainSubject;
    public decimal BaseSalary;
    public int ExperienceYears;

   public Teacher(string firstName, string lastName, int age, string email, string id,
               string department, string mainSubject, decimal baseSalary, int experienceYears)
            : base(firstName, lastName, age, email, id)
   {
    this.Department = department;
    this.MainSubject = mainSubject;
    this.BaseSalary = baseSalary;
    this.ExperienceYears = experienceYears;
   }

   public void ShowTeacherInfo()
   {
    Console.WriteLine("=== Müəllim məlumatları ===");
    ShowBasicInfo();
    Console.WriteLine($"Kafedra: {Department}", "Əsas fənn: {MainSubject}", "Təcrübə (il): {ExperienceYears}");
    
   }
    public decimal CalculateSalary()
    {
    return BaseSalary + (ExperienceYears * 50);
}
    }