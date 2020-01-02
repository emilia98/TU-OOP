using System.Text;

namespace Problem_02_Car
{
    public class Car
    {
        // field
        private string make;

        // field
        private string color;

        // field
        private string number;


        public Car(string make, string color, string number)
        {
            this.make = make;
            this.color = color;
            this.number = number;
        }

        public Car()
        {
            this.make = "";
            this.color = "";
            this.number = "";
        }

        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public string Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Make: {NotAnnounced(Make)}");
            sb.AppendLine($"Color: {NotAnnounced(color)}");
            sb.AppendLine($"Number: {NotAnnounced(number)}");
            return sb.ToString();
        }

        private string NotAnnounced(string prop)
        {
            return prop != "" ? prop : "N\\A";
        }
    }
}
