using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[5];

            Person person_1 = new Person();
            Person person_2 = new Person("Pesho", "Ivanov", "1234567");
            Person person_3 = new Person("ivan", "Peshev", "7654321");
            person_3.FirstName = "Ivan";
            Person person_4 = new Person("maria", "stefanova", "9876543");
            person_4.MiddleName = "Ivanova";
            person_4.LastName = "Stefanova";
            Person person_5 = new Person();
            person_5.MiddleName = null;

            people[0] = person_1;
            people[1] = person_2;
            people[2] = person_3;
            people[3] = person_4;
            people[4] = person_5;

            Console.WriteLine(new string('-', 15));
            Console.Write("Search (by faculty number): ");
            string facNumberToFind = Console.ReadLine();
            Console.WriteLine(new string('-', 15));

            bool hasFound = false;
            foreach (var person in people)
            {
                if(person.IsMatchingFacultyNumber(facNumberToFind))
                {
                    person.PrintInfo();
                    hasFound = true;
                }
            }

            if(!hasFound)
            {
                Console.WriteLine("No results...");
            }
        }
    }
}
