using System;
using System.Collections.Generic;
using System.Text;

namespace Task2._1_tekrar.Models
{
    internal class Group
    {
        public Student[] students = new Student[0];
        int groupNo;


        public void AddStudents(Student std)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = std;
        }
    }
}
