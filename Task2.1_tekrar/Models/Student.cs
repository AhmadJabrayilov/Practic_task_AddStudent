using System;
using System.Collections.Generic;
using System.Text;

namespace Task2._1_tekrar.Models
{
    internal class Student : Person
    {
        static private int _id;
        public int Id { get;  }
        string[] Lessons = new string[0];
        


        public Student(string name, string surname, int age) : base(name, surname, age)
        {
            _id++;
            Id = _id;
            
        }

        public void ShowInfoStudent()
        {
            Console.WriteLine($"ID: {Id}\nName: {Name}\nSurname: {SurName}\nAge: {Age} ");

            Console.WriteLine("\n");
            Console.WriteLine("Student Lessons");
            foreach (string item in Lessons)
            {
                Console.WriteLine(item);
            }

          
        }

        public void AddLessons(string lsn)
        {
            Array.Resize(ref Lessons, Lessons.Length + 1);
            Lessons[Lessons.Length - 1] = lsn;

           
        }
        public Student()
        {

        }

      

    }
}
