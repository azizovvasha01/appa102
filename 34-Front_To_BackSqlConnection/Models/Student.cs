using System.ComponentModel.DataAnnotations;

namespace FrontToBackSqlConnection.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }

        [Range(16, 80)]
        public int Age { get; set; }
    }
}