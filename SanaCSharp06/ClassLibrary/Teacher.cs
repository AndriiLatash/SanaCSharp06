using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Teacher : Person
    {
        public string Position { set; get; }
        public string Department { set; get; }
        public string UniversityName { set; get; }

        public Teacher(string position, string department, string universityName, string name, string lastName, DateTime dateOfBirth)
            : base(name, lastName, dateOfBirth)
        {
            Position = position;
            Department = department;
            UniversityName = universityName;
        }
        public Teacher(string position, string name, string lastName) : base(name, lastName)
        {
            Position = position;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Date of Birth: {DateOfBirth.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Position {Position}");
            Console.WriteLine($"Department {Department}");
            Console.WriteLine($"University Name {UniversityName}");
        }
    }
}
