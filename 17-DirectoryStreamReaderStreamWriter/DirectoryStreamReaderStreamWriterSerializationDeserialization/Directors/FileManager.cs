using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DirectoryStreamReaderStreamWriterSerializationDeserialization.Directors
{
    internal class FileManager
    {
        public string FolderPath { get; set; }
        public string TextFilePath { get; set; }
        public string JsonFilePath { get; set; }

        public FileManager()
        {
            FolderPath = "StudentData";
            TextFilePath = Path.Combine(FolderPath, "students.txt");
            JsonFilePath = Path.Combine(FolderPath, "students.json");
        }

       
        public void CreateFolder()
        {
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
                Console.WriteLine($"Qovluq yaradildi: {FolderPath}");
            }
            else
            {
                Console.WriteLine($"Qovluq artiq movcuddur: {FolderPath}");
            }
        }

        
        public void DeleteFolder()
        {
            if (Directory.Exists(FolderPath))
            {
                Directory.Delete(FolderPath, true);
                Console.WriteLine($"Qovluq silindi: {FolderPath}");
            }
            else
            {
                Console.WriteLine($"Silecrk qovluq tapilmadi: {FolderPath}");
            }
        }

        
        public bool CheckFolderExists()
        {
            return Directory.Exists(FolderPath);
        }

        
        public void WriteStudentToFile(Student student)
        {
           
            if (!Directory.Exists(FolderPath))
                Directory.CreateDirectory(FolderPath);

            
            using (var sw = new StreamWriter(TextFilePath, append: true))
            {
                sw.WriteLine(student.ToString());
            }
            Console.WriteLine($"Telebe fayla yazildi: {student.Name}");
        }
        public void WriteAllStudentsToFile(List<Student> students)
        {
           
            if (!Directory.Exists(FolderPath))
                Directory.CreateDirectory(FolderPath);

           
            File.WriteAllText(TextFilePath, string.Empty);

            using (var sw = new StreamWriter(TextFilePath, append: true))
            {
                foreach (var s in students)
                {
                    sw.WriteLine(s.ToString());
                }
            }
            Console.WriteLine($"Umumi {students.Count} telebe fayla yazildi");
        }

       
        public List<Student> ReadStudentsFromFile()
        {
            var list = new List<Student>();

            if (!File.Exists(TextFilePath))
            {
                Console.WriteLine($"Fayl tapilmadi: {TextFilePath}");
                return list;
            }

            using (var sr = new StreamReader(TextFilePath))
            {
                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    var parts = line.Split(',');
                    if (parts.Length < 5)
                        continue; 

                   
                    if (!int.TryParse(parts[0], out int id)) continue;
                    string name = parts[1];
                    string surname = parts[2];
                    if (!int.TryParse(parts[3], out int age)) continue;
                    if (!double.TryParse(parts[4], NumberStyles.Any, CultureInfo.InvariantCulture, out double grade)) continue;

                    var student = new Student(name, surname, age, grade, id);
                    list.Add(student);
                }
            }

            Console.WriteLine($"Fayldan {list.Count} telebe oxundu");
            return list;
        }

       
        public void SerializeToJson(List<Student> students)
        {
            if (!Directory.Exists(FolderPath))
                Directory.CreateDirectory(FolderPath);

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(students, options);
            File.WriteAllText(JsonFilePath, json);
            Console.WriteLine("Telebeler JSON formatinda yadda saxlanildi");
        }

        
        public List<Student> DeserializeFromJson()
        {
            var list = new List<Student>();

            if (!File.Exists(JsonFilePath))
            {
                Console.WriteLine($"JSON faylı tapılmadı: {JsonFilePath}");
                return list;
            }

            string json = File.ReadAllText(JsonFilePath);
            try
            {
                var des = JsonSerializer.Deserialize<List<Student>>(json);
                if (des != null)
                {
                    list = des;
                    Console.WriteLine($"JSON-dan {list.Count} telebe yuklendi");
                }
                else
                {
                    Console.WriteLine("JSON-dan obyekt yaradilmadi (null)");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"JSON deserializasiya zamanı xeta: {ex.Message}");
            }

            return list;
        }
    }

    
    
}
