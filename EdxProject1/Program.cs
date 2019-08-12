using System;

namespace EdxProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "";
            string lastName = "";
            int age = 0;
            string street = "";
            string city = "";
            string country = "";
            DateTime birthDate;

            firstName = "Satya";
            lastName = "Javvadi";
            age = 50;
            street = "4306, 156th Ave";
            city = "Redmond";
            country = "US";
            birthDate = new DateTime(1945, 6, 21);

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            Console.WriteLine("{0} years of old", age);

            Console.WriteLine(street + "," + city + "," + country);

            Console.WriteLine($"Born on {birthDate}");

        }
    }
}
