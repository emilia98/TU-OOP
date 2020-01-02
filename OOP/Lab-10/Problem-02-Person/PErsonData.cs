using System;

namespace Problem_02_Person
{
    class PersonData
    {
        static void Main()
        {
            Person person1 = new Person("Maria", "Petrova", "Ivanova", "0123456789", "QWERTY123");
            person1.ShowPersonInfo();
            person1.ChangeLastName();
            person1.ShowPersonInfo();

            Console.WriteLine(new string('-', 15));

            Person person2 = new Person();
            person2.ShowPersonInfo();
            person2.ChangeLastName();
            person2.ShowPersonInfo();

            Console.WriteLine(new string('-', 15));

            Student student1 = new Student("KST", 1, "21805000");
            student1.ShowStudentInfo();
            student1.ChangeGroup();
            student1.ChangeLastName();
            student1.ShowFullInfo();

            Console.WriteLine(new string('-', 15));

            Student student2 = new Student();
            student2.ShowStudentInfo();
            Console.WriteLine();
            student2.ChangeGroup();
            student2.ChangeLastName();
            student2.ShowFullInfo();
        }
    }
}
