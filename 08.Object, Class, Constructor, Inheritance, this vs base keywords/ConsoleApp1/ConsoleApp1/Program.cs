using ConsoleApp1.Models;
using System.Security.Cryptography.X509Certificates;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Student s1 = new Student("Deniz", "Azizova", 20, "deniz@example.com", "ITT", "IT", 89, 3);
            Student s2 = new Student("Kamal", "Rzayev", 21, "kamal@example.com", "ITT", "IT", 92, 4);
            Student s3 = new Student("Aylin", "Hüseynova", 19, "aylin@example.com", "ITT", "IT", 68, 2);

            Teacher t1 = new Teacher("Elvin", "Quliyev", 40, "elvin@univ.az", "ITT", "Kompüter elmləri", "Proqramlaşdırma", 5000, 5);
            Teacher t2 = new Teacher("Leyla", "Əliyeva", 35, "leyla@univ.az", "ITT", "Riyaziyyat", "Alqoritmlər", 3000, 8);

            
            Administrator admin = new Administrator("Rauf", "Məmmədov", 45, "rauf@univ.az", "ITT", "Dekan", "İT fakültəsi", 5);

            
            s1.ShowStudentInfo();
            Console.WriteLine("Təqaüd: " + s1.CalculateScholarship() + " AZN\n");

            s2.ShowStudentInfo();
            Console.WriteLine("Təqaüd: " + s2.CalculateScholarship() + " AZN\n");

            s3.ShowStudentInfo();
            Console.WriteLine("Təqaüd: " + s3.CalculateScholarship() + " AZN\n");

            
            t1.ShowTeacherInfo();
            Console.WriteLine("Maaş: " + t1.CalculateSalary() + " AZN\n");

            t2.ShowTeacherInfo();
            Console.WriteLine("Maaş: " + t2.CalculateSalary() + " AZN\n");

           
            admin.ShowAdminInfo();
            admin.GrantAccess(s1);

            
            int totalScholarship = (int)(s1.CalculateScholarship() + s2.CalculateScholarship() + s3.CalculateScholarship());
            int totalSalary = (int) (t1.CalculateSalary() + t2.CalculateSalary());

            Console.WriteLine("=== STATİSTİKA ===");
            Console.WriteLine("Ümumi təqaüd xərci: " + totalScholarship + " AZN");
            Console.WriteLine("Ümumi maaş xərci: " + totalSalary + " AZN");
        }
    }

}
