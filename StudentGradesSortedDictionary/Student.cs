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
        private List<int> grades;
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
        public List<int> getGrades()
        {
            return grades;
        }
    }
}
