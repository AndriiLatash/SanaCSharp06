using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LibraryUser : Person
    {
        public string ReadingCardNumber { set; get; }
        public DateTime DateOfIssue { set; get; }
        public string AmountOfMonthlyReadersFee { set; get; }

        public LibraryUser(string readingCardNumber, DateTime dateOfIssue, string amountOfMonthlyReadersFee, string name, string lastName, DateTime dateOfBirth)
            :base(name, lastName, dateOfBirth)
        {
            ReadingCardNumber = readingCardNumber;
            DateOfIssue = dateOfIssue;
            AmountOfMonthlyReadersFee = amountOfMonthlyReadersFee;  
        }
        public LibraryUser(string readingCardNumber, string name, string lastName) :base(name, lastName)
        {
            ReadingCardNumber = readingCardNumber;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Date of Birth: {DateOfBirth.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Reading Card Number: {ReadingCardNumber}");
            Console.WriteLine($"Date Of Issue: {DateOfIssue.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Amount Of Monthly Readers Fee: {AmountOfMonthlyReadersFee}");

        }
    }
}
