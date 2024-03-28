namespace Class_Task_28._03._2024
{
    internal class Program
    {
       static void main()
        {
            Student student1 = new Student("Rauf", "Dostuyev", "AB106", 95, true);
            student1.GetInfo();
            student1.CheckGraduation();
            student1.GetDiplomaDegree();

            Console.WriteLine();

            Student student2 = new Student("Sabir", "Guliyev", "AB106", 67, false);
            student2.GetInfo();
            student2.CheckGraduation();
            student2.GetDiplomaDegree();

            Student student3 = new Student("Nurlan", "Abbasov", "AB106", 98, true);
            student3.GetInfo();
            student3.CheckGraduation();
            student3.GetDiplomaDegree();

            Student student4 = new Student("Axund", "Mammadov", "AB106", 56, false);
            student4.GetInfo();
            student4.CheckGraduation();
            student4.GetDiplomaDegree();

            Student student5 = new Student("Huseyinova", "Nermin", "AB106", 78, true);

        }
       
    }
 public class Student
        {
            public string Name;
            public string Surname;
            public string Group;
            public int Point;
            public bool IsGraduated;
            public Student(string name, string surname, string group, int point, bool isGraduated)
            {
                Name = name;
                Surname = surname;
                Group = group;
                Point = point;
                IsGraduated = isGraduated;
            }

            public void GetInfo()
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Surname: {Surname}");
                Console.WriteLine($"Group: {Group}");
                Console.WriteLine($"Point: {Point}");
                Console.WriteLine($"Is Graduated: {(IsGraduated ? "Yes" : "No")}");
            }

            public void CheckGraduation()
            {
                if (IsGraduated)
                {
                    Console.WriteLine($"{Name} {Surname} Mezun olub.");
                }
                else
                {
                    Console.WriteLine($"{Name} {Surname} Mezun olmayib.");
                }
            }

            public void GetDiplomaDegree()
            {
                string degree = Point switch
                {
                    int p when p < 65 => "Standart",
                    int p when p >= 65 && p < 80 => "Heveslendirici",
                    int p when p >= 80 && p < 90 => "Zerbeci",
                    int p when p >= 90 => "Elaci",
                    _ => throw new ArgumentException("Invalid point value"),
                };

                Console.WriteLine($"{Name} {Surname} {degree} Ile Diplom Qiymetlendirilib.");
            }

        }
}
