using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradesSortedDictionary
{
    internal class Student
    {
        private string student_name;
        private List<int> grades = new List<int>();
        public Student(string name) 
        {
            student_name = name;
        }
        public string getName()
        {
            return student_name;
        }
        public void addGrade(int grade)
        {
            grades.Add(grade);
        }
        private int findGrade(int grade)
        {
            int c = 0;
            foreach (var item in grades)
            {
                if (item == grade) 
                {
                    return c;
                }
                c++;
            }
            return 0;
        }
        public void editGrade(int oldGrade, int newGrade)
        {
            grades[findGrade(oldGrade)] = newGrade;
        }
        public List<int> getGrades()
        {
            return grades;
        }
    }
}
