using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student : Eentrant
    {
        public string Course { set; get; }
        public string Group { set; get; }
        public string Faculty { set; get; }
        public string UniversityName { set; get; }

        public Student(string course, string group, string faculty, string universityName,
                int certificatePoints, int firstExam, int secondExam, int thirdExam,
                string schoolName, string name, string lastName, DateTime dateOfBirth)
                : base(certificatePoints, firstExam, secondExam, thirdExam, schoolName, name, lastName, dateOfBirth)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            UniversityName = universityName;
        }
        public Student(string course, string group, int certificatePoints, int firstExam, int secondExam, int thirdExam,
                string schoolName, string name, string lastName, DateTime dateOfBirth) : base(certificatePoints, firstExam, secondExam, thirdExam, schoolName, name, lastName, dateOfBirth)
        {
            Course = course;
            Group = group;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Date of Birth: {DateOfBirth.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"First Exam {FirstExam}");
            Console.WriteLine($"Second Exam {SecondExam}");
            Console.WriteLine($"Third Exam {ThirdExam}");
            Console.WriteLine($"Course {Course}");
            Console.WriteLine($"Group {Group}");
            Console.WriteLine($"Faculty {Faculty}");
            Console.WriteLine($"University Name {UniversityName}");
        }
    }
}

