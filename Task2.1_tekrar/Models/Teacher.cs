using System;
using System.Collections.Generic;
using System.Text;

namespace Task2._1_tekrar.Models
{
    internal class Teacher : Person
    {
        static private int _id;
        public int Id { get; }
        private int _experience;
        public int Experience
        {
            get { return _experience; }
            set
            {
                if (value > 0 && value <= 80)
                {
                    _experience = value;
                }
            }

        }


        public Teacher(int exp, string name, string surname, int age):base(name,surname,age)
        {
            _id++;
            Id = _id;
            Experience = exp;
        }

        public void ShowInfoTeacher()
        {
            Console.WriteLine($"ID: {Id}\nName: {Name}\nSurname: {SurName}\nAge: {Age}\nExperience: {Experience} years ");
        }
    }
}
