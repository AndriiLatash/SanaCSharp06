// See https://aka.ms/new-console-template for more information
using ClassLibrary;
using System;


Person person = new Person("Andrew", "Smith", new DateTime(2000, 2, 5));
Eentrant entrant = new Eentrant(11, 175, 184, 190, "Lyceum 25", "Mary", "Johnson", new DateTime(2000, 3, 15));
Student student = new Student("2", "IPZ-21", "FIKT", "ZDU", 200, 75, 85, 90, "Lyceum 24", "Mary", "Johnson", new DateTime(2003, 12, 15));
Teacher teacher = new Teacher("Professor", "Mathematics", "ZDU", "Jason", "Tatum", new DateTime(1975, 5, 20));
LibraryUser user = new LibraryUser("123456789", new DateTime(2022, 3, 1), "10$", "John", "James", new DateTime(1990, 1, 1));

person.ShowInfo();
entrant.ShowInfo();
student.ShowInfo();
teacher.ShowInfo();
user.ShowInfo();