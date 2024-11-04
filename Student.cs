using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI_C_sharp_2024_2025_M1IL
{
    public class Student
    {
        public string FirstName;
        public string Name;
        public DateTime BirthDay;
        public float[] Grades = new float[5];

        public Student(string firstName, string name, DateTime birthDay, float[] grades)
        {
            FirstName = firstName;
            Name = name;
            BirthDay = birthDay;
            Grades = grades;
        }

        public float FinalGrade()
        {
            float sum = 0;
            foreach (float grade in Grades)
            {
                sum += grade;
            }
            return sum / Grades.Length;
        }
    }
}
