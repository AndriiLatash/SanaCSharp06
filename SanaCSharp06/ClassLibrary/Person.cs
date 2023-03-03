namespace ClassLibrary
{
    public class Person
    {
        public string Name { set; get; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person()
        {

        }
        public Person(string name, string lastName, DateTime dateOfBirth)
        {
            Name = name;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
        public Person(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Date of Birth: {DateOfBirth.ToString("dd/MM/yyyy")}");
        }
    }
}