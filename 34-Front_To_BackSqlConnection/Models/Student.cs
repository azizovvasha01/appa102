using System.ComponentModel.DataAnnotations;

namespace FrontToBackSqlConnection.Models
{
    public class Student
    {
        public int Id { get; set; }

        
        
        public string Name { get; set; }

       
        public string Surname { get; set; }

        
        public int Age { get; set; }
    }
}