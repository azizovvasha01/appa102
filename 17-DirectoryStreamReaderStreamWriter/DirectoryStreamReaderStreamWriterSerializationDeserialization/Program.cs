
using DirectoryStreamReaderStreamWriterSerializationDeserialization.Directors;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        var s1 = new Student("Ali", "Memmedov", 20, 85.5, 1);
        var s2 = new Student("Leyla", "Hesenova", 19, 92.0, 2);
        var s3 = new Student("Vuqar", "Eliyev", 21, 78.5, 3);
        var s4 = new Student("Nigar", "Ehmedova", 20, 88.0, 4);
        var s5 = new Student("Resad", "Quliyev", 22, 95.5, 5);

        var students = new List<Student> { s1, s2, s3, s4, s5 };

        Console.WriteLine("===== Telebelerin melumatlari ====");
        foreach (var s in students)
        {
            s.DisplayInfo();
        }
        Console.WriteLine();


        var fm = new FileManager();

        Console.WriteLine("===== Directory emeliyyatlari =====");
        bool existsBefore = fm.CheckFolderExists();
        Console.WriteLine($"Qovluq movcuddur : {existsBefore}");

        if (existsBefore)
        {
            fm.DeleteFolder();
        }

        fm.CreateFolder();

        bool existsAfter = fm.CheckFolderExists();
        Console.WriteLine($"Qovluq movcuddur : {existsAfter}");
        Console.WriteLine();

        
        Console.WriteLine("===== StreamWriter: Bir-bir yazma =====");
        
        foreach (var s in students)
        {
            fm.WriteStudentToFile(s);
        }
        Console.WriteLine();

        Console.WriteLine("===== StreamWriter: Toplu yazma =====");
       
        fm.WriteAllStudentsToFile(students);
        Console.WriteLine();

        
        Console.WriteLine("====== StreamReader: Fayldan oxuma ======");
        var readStudents = fm.ReadStudentsFromFile();
        Console.WriteLine($"Oxunan telebe sayı: {readStudents.Count}");
        foreach (var rs in readStudents)
        {
            rs.DisplayInfo();
        }
        Console.WriteLine();

        
        Console.WriteLine("===== Serialization: JSON-a yazma =====");
        fm.SerializeToJson(students);
        Console.WriteLine($"JSON fayl yolu: {fm.JsonFilePath}");
        Console.WriteLine();

        
        Console.WriteLine("===== Deserialization: JSON-dan oxuma =====");
        var jsonStudents = fm.DeserializeFromJson();
        Console.WriteLine($"JSON-dan oxunan telebe sayi: {jsonStudents.Count}");
        foreach (var js in jsonStudents)
        {
            js.DisplayInfo();
        }
        Console.WriteLine();

        
        Console.WriteLine("===== Fayl mezmunlari =====");
        if (File.Exists(fm.TextFilePath))
        {
            Console.WriteLine($"==== {fm.TextFilePath} mezmunu (CSV) ====");
            string txt = File.ReadAllText(fm.TextFilePath);
            Console.WriteLine(txt);
        }
        else
        {
            Console.WriteLine($"TXT fayl tapılmadi: {fm.TextFilePath}");
        }

        if (File.Exists(fm.JsonFilePath))
        {
            Console.WriteLine($"==== {fm.JsonFilePath} mezmunu (JSON) ====");
            string j = File.ReadAllText(fm.JsonFilePath);
            Console.WriteLine(j);
        }
        else
        {
            Console.WriteLine($"JSON fayl tapılmadi: {fm.JsonFilePath}");
        }
        Console.WriteLine();

        
        Console.WriteLine("==== Statistika =====");
        var allForStats = new List<Student>();
       
        if (jsonStudents.Count > 0)
            allForStats = jsonStudents;
        else if (readStudents.Count > 0)
            allForStats = readStudents;
        else
            allForStats = students;

        Console.WriteLine($"Umumi telebe sayi: {allForStats.Count}");

        if (allForStats.Count > 0)
        {
            double sum = 0;
            double maxGrade = double.MinValue;
            double minGrade = double.MaxValue;
            int count90plus = 0;

            foreach (var st in allForStats)
            {
                sum += st.Grade;
                if (st.Grade > maxGrade) maxGrade = st.Grade;
                if (st.Grade < minGrade) minGrade = st.Grade;
                if (st.Grade >= 90.0) count90plus++;
            }

            double average = sum / allForStats.Count;
            Console.WriteLine($"Orta qiymet: {average.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"En yuksek qiymet: {maxGrade.ToString(CultureInfo.InvariantCulture)}");
            Console.WriteLine($"En asagi qiymet: {minGrade.ToString(CultureInfo.InvariantCulture)}");
            Console.WriteLine($"90+ qiymetli telebe sayi: {count90plus}");
        }

        
        if (File.Exists(fm.TextFilePath))
        {
            var fiTxt = new FileInfo(fm.TextFilePath);
            Console.WriteLine($"students.txt olcusu: {fiTxt.Length} bayt");
        }
        else
        {
            Console.WriteLine("students.txt faylı yoxdur");
        }

        if (File.Exists(fm.JsonFilePath))
        {
            var fiJson = new FileInfo(fm.JsonFilePath);
            Console.WriteLine($"students.json olcusu: {fiJson.Length} bayt");
        }
        else
        {
            Console.WriteLine("students.json faylı yoxdur");
        }

        Console.WriteLine();
        Console.WriteLine("==== Proqram tamamlandı ====");
    }
}

