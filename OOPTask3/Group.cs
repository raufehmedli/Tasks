using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask3
{
    internal class Group
    {
        public int Id;
        public string Name { get; set; }
        public Group(int id, string name)
        {
            Id = id;
            Name = name;
        }

        Student[] students = { };
        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length+1);
            students[students.Length-1] = student;
        }
        public void RemoveStudent(Student student)
        {
            Student[] newStudents = { };
            foreach (Student stu in students)
            {
                if (!student.Equals(stu))
                {
                    Array.Resize(ref newStudents, newStudents.Length + 1);
                    newStudents[newStudents.Length - 1] = stu;
                }
            }
            students = newStudents;
        }

        public void GetStudents()
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.GetFullInfo());
            }
        }
    }
}
