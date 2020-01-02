using System.Text;

namespace Problem_03_Person
{
    public class Person
    {
        // field
        private string firstName;

        // field
        private string lastName;

        // field
        private string phoneNumber;

        public Person(string firstName, string lastName, string phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
        }

        public Person()
        {
            this.firstName = "";
            this.lastName = "";
            this.phoneNumber = "";
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"First Name: {NotAnnounced(FirstName)}");
            sb.AppendLine($"Last Name: {NotAnnounced(LastName)}");
            sb.AppendLine($"Phone Number: {NotAnnounced(PhoneNumber)}");
            return sb.ToString();
        }

        private string NotAnnounced(string prop) => prop != "" ? prop : "N\\A";
    }
}
