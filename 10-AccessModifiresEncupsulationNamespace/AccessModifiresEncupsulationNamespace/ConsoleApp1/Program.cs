using ConsoleApp1.Models;
using System.Reflection;

Student student = new Student();

//typeof(Student).GetField("name", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(student, "Samir");
//var StudentName = typeof(Student).GetField("name", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(student);


//Console.WriteLine(studentName);



Car car = new Car();

car.HorsePower = 50;

Console.WriteLine(car.HorsePower);

