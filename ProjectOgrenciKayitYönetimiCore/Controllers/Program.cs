

namespace ProjectOgrenciKayitYönetimiCoreMVCUI.Controllers
{
      public class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>
        {
            new Student { FirstName = "Ahmet", LastName = "Yılmaz", FillPercentage = 85.0 },
            new Student { FirstName = "Ayşe", LastName = "Demir", FillPercentage = 70.0 },
            new Student { FirstName = "Mehmet", LastName = "Kara", FillPercentage = 95.0 },
            new Student { FirstName = "Fatma", LastName = "Şahin", FillPercentage = 60.0 },
            // Diğer öğrencileri buraya ekleyebilirsiniz.
        };

            // Profil doluluk oranına göre öğrencileri sıralıyoruz.
            students.Sort((a, b) => b.FillPercentage.CompareTo(a.FillPercentage));

            // En dolu profillere sahip öğrencileri listeliyoruz.
            foreach (var student in students)
            {
                Console.WriteLine($"Ad: {student.FirstName}, Soyad: {student.LastName}, Doluluk Oranı: {student.FillPercentage}%");
            }
        }
    }
}
