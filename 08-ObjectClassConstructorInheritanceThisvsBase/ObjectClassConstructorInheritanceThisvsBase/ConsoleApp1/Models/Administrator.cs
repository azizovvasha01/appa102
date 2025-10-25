using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1.Models;

class Administrator : Person
{
    public string Position;
    public string Department;
    public int AccessLevel;

    public Administrator(string firstName, string lastName, int age, string email, string id,
                         string position, string department, int accessLevel)
        : base(firstName, lastName, age, email, id)
    {
        this.Position = position;
        this.Department = department;
        this.AccessLevel = accessLevel;
    }

    public void ShowAdminInfo()
    {
        Console.WriteLine("=== İdarəçi məlumatları ===");
        ShowBasicInfo();
        Console.WriteLine($"Vəzifə: {Position}", "Şöbə/Kafedra: {Department}", "Giriş səviyyəsi: {AccessLevel}");
        
    }

    public void GrantAccess(Student student)
    {
        Console.WriteLine($"\n {GetFullName()} tələbə {student.GetFullName()} üçün sistemə giriş icazəsi verdi.\n");
    }
}