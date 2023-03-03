using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary
{
    public class Eentrant : Person
    {
        public int CertificatePoints { get; set; }
        public int FirstExam { get; set; }
        public int SecondExam { get; set; }
        public int ThirdExam { get; set; }
        public string SchoolName { get; set; }

        public Eentrant(int certificatePoints, int firstExam, int secondExam, int thirdExam, string schoolName, string name, string lastName, DateTime dateOfBirth):base(name,lastName, dateOfBirth)
        {
            CertificatePoints = certificatePoints;
            FirstExam = firstExam;
            SecondExam = secondExam;
            ThirdExam = thirdExam;
            SchoolName = schoolName;    
        }
        public Eentrant(int certificatePoints, int firstExam, int secondExam, int thirdExam, string name, string lastName, DateTime dateOfBirth) : base(name, lastName, dateOfBirth)
        {
            CertificatePoints=certificatePoints;
            FirstExam=firstExam;
            SecondExam = secondExam;
            ThirdExam = thirdExam;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Date of Birth: {DateOfBirth.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"First Exam {FirstExam}"); 
            Console.WriteLine($"Second Exam {SecondExam}"); 
            Console.WriteLine($"Third Exam {ThirdExam}"); 
            
        }
    }
}
