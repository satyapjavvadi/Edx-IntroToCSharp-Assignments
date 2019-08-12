using System;

namespace EdxAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student Information
             
        
                string FirstName = "";
                string LastName = "";
                DateTime BirthDate;
                string AddressLine1 = "";
                string AddressLine2 = "";
                string City = "";
                string State = "";
                string Zip = "";
                string Country = "";

                FirstName = "Abhi";
                LastName = "JAvvadi";
                BirthDate = new DateTime(2007, 9, 5);
                AddressLine1 = "4306";
                AddressLine2 = "156th Ave";
                City = "Redmond";
                State = "WA";
                Zip = "98052";
                Country = "USA";

                Console.WriteLine("Student Information :");
                Console.WriteLine(FirstName);
                Console.WriteLine(LastName);
                Console.WriteLine(BirthDate);
                Console.WriteLine(AddressLine1);
                Console.WriteLine(AddressLine2);
                Console.WriteLine(City);
                Console.WriteLine(State);
                Console.WriteLine(Zip);
                Console.WriteLine(Country);


            // Teacher Information
            string TfirstName = "";
            string TlastName = "";
            DateTime TbirthDate;
            string TAddressLine1 = "";
            string TAddressLine2 = "";
            string TCity = "";
            string TState = "";
            string TZip = "";
            string TCountry = "";

            TfirstName = "Satya";
            TlastName = "Javvadi";
            TbirthDate = new DateTime(1979, 6, 21);
            TAddressLine1 = "4306";
            TAddressLine2 = "156th Ave";
            TCity = "Redmond";
            TState = "WA";
            TZip = "98052";
            TCountry = "USA";

            Console.WriteLine("Teacher Information :");
            Console.WriteLine(TfirstName);
            Console.WriteLine(TlastName);
            Console.WriteLine(TbirthDate);
            Console.WriteLine(TAddressLine1);
            Console.WriteLine(TAddressLine2);
            Console.WriteLine(TState);
            Console.WriteLine(TZip);
            Console.WriteLine(TCountry);

            // UProgram Information

            string ProgramName = "";
            string DepartmentHead = "";
            string Degrees = "";

            ProgramName = "ComputerScience";
            DepartmentHead = "Prasanna";
            Degrees = "Bachelors";

            Console.WriteLine("UProgram Information :");
            Console.WriteLine(ProgramName);
            Console.WriteLine(DepartmentHead);
            Console.WriteLine(Degrees);

            //Degree Information

            string DegreeName = "";
            int CreditsRequired = 0;

            DegreeName = "Bachelors";
            CreditsRequired = 3;

            Console.WriteLine("Degree Information :");
            Console.WriteLine(DegreeName);
            Console.WriteLine(CreditsRequired);

            // Course Information

            string CourseName = "";
            int Credits = 0;
            int DurationinWeeks = 0;
            string Teacher = "";

            CourseName = "Computer Science";
            Credits = 3;
            DurationinWeeks = 12;
            Teacher = "Prasanna";

            Console.WriteLine("Course Information :");
            Console.WriteLine(CourseName);
            Console.WriteLine(Credits);
            Console.WriteLine(DurationinWeeks);
            Console.WriteLine(Teacher);
        }
    }
}
