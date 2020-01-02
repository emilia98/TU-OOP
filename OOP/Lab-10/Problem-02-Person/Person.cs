using System;

namespace Problem_02_Person
{
    public class Person
    {
        // field
        private string firstName;

        // field
        private string middleName;

        // field
        private string lastName;

        // field
        private string egn;

        // field
        private string idCard;

        public string FirstName
        {
            get { return this.firstName; }
        }

        public string MiddleName
        {
            get { return this.middleName; }
        }

        public string LastName
        {
            get { return this.lastName; }
        }

        public string EGN
        {
            get { return this.egn; }
        }

        public string IdCard
        {
            get { return this.idCard; }
        }

        public Person(string firstName, string middleName, string lastName, string egn, string idCard)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.egn = egn;
            this.idCard = idCard;
        }

        public Person()
        {
            Console.Write("First name = ");
            this.firstName = Console.ReadLine();
            Console.Write("Middle name = ");
            this.middleName = Console.ReadLine();
            Console.Write("Last name = ");
            this.lastName = Console.ReadLine();
            Console.Write("EGN = ");
            this.egn = Console.ReadLine();
            Console.Write("ID Card = ");
            this.idCard = Console.ReadLine();
        }

        public void ChangeLastName()
        {
            Console.Write("Last name = ");
            this.lastName = Console.ReadLine();
        }

        public void ShowPersonInfo()
        {
            Console.WriteLine($"Names: {this.FirstName} {this.MiddleName} {this.LastName}");
            Console.WriteLine($"EGN: {this.EGN}");
            Console.WriteLine($"ID Card = {this.IdCard}");
        }
    }
}
