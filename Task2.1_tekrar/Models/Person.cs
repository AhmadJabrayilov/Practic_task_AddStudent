using System;

using System.Text;

namespace Task2._1_tekrar.Models
{
    internal class Person
    {
        private int _age;
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0 && value < 120)
                {
                    _age = value;
                }
            }
        }

        public Person(string name,string surname,int age)
        {
            Name = name;
            SurName = surname;
            Age = age;
        }
        public Person()
        {

        }



    }
}
