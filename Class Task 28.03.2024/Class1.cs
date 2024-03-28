using System;

public class Class1
{
	public Class1()
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
