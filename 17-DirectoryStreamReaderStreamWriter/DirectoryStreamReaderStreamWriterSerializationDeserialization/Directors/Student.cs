using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryStreamReaderStreamWriterSerializationDeserialization.Directors
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Surname { get; set; } = "";
        public int Age { get; set; }
        public double Grade { get; set; }


        public Student(string name, string surname, int age, double grade, int id);
        
        

        public Student() { }

        
        public void DisplayInfo()
        {
            Console.WriteLine($"[{Id}] {Name} {Surname} - Yas: {Age}, Qiymet: {Grade.ToString(CultureInfo.InvariantCulture)}");
        }

        
        public override string ToString()
        {
            
            return $"{Id},{Name},{Surname},{Age},{Grade.ToString(CultureInfo.InvariantCulture)}";
        }
    }   
}
