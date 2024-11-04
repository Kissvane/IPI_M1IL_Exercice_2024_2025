using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI_C_sharp_2024_2025_M1IL
{
    public enum Level { PS, MS, GS, CP, CE1, CE2, CM1, CM2}

    public class Grade
    {
        public string Name;
        public Level Level;
        public int MaxStudentNumber;
        public List<Student> Students;

        public Grade(string name, Level level, int maxStudentNumber, List<Student> students)
        {
            Name = name;
            Level = level;
            MaxStudentNumber = maxStudentNumber;
            Students = students;
        }

        public List<Student> Promotion()
        {
            List<Student> result = new List<Student>();
            foreach (Student student in Students)
            {
                if(student.FinalGrade() >= 10)
                {
                    result.Add(student);
                }
            }

            return result;
        }
    }
}
