using System;
using System.Collections.Generic;
using Task2._1_tekrar.Models;

namespace Task2._1_tekrar
{
    internal class Program
    {
        private static IEnumerable<Student> students;

        static void Main(string[] args)
        {
            int tAge;
            int exp;
            int sAge;

            Console.Write("Input Teacher's name: ");
            string tName = Console.ReadLine();

            Console.Write("Input Teacher's surname: ");
            string tsurName = Console.ReadLine();

            do
            {
                Console.Write("Input Teacher's age: ");
                tAge = Convert.ToInt32(Console.ReadLine());
            } while (tAge < 0);

            do
            {
                Console.Write("Input Teacher's experience: ");
                exp = Convert.ToInt32(Console.ReadLine());
            } while (exp < 0 || exp > 80);

            Teacher th1 = new Teacher(exp, tName, tsurName, tAge);
            th1.ShowInfoTeacher();

            Console.WriteLine("\n*****************\n");



            Console.Write("Input Student's name: ");
            string sName = Console.ReadLine();

            Console.Write("Input Student's surname: ");
            string ssurName = Console.ReadLine();

            do
            {
                Console.Write("Input Student's age: ");
                sAge = Convert.ToInt32(Console.ReadLine());
            } while (sAge < 0);

            Student std1 = new Student(sName, ssurName, sAge);

            

            std1.AddLessons("C#");
            std1.AddLessons("MSQL");
            std1.AddLessons("HTML5");
            std1.AddLessons("CCS3");

            

            std1.ShowInfoStudent();

            Student std2 = new Student();
            std2.Name = "Ahmed";
            std2.SurName = "Jabrayilov";
            std2.Age = 23;

            Student std3 = new Student();
            std3.Name = "Ilkin";
            std3.SurName = "Ibrahimov";
            std3.Age = 20;

            Group gp1 = new Group();

            gp1.AddStudents(std1);
            gp1.AddStudents(std2);
            gp1.AddStudents(std3);

            Console.WriteLine("*******************************");

            foreach (Student item in gp1.students)
            {
                Console.WriteLine($"{item.Name} {item.SurName} // {item.Age}");
            }

        }
    }
}
