using System;

namespace EdxFinalAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            GetStudentInformation();
            GetTeacherInformation();
            
        }
        public static void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name :");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name :");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Student's date-of-birth :");
            DateTime BirthDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter the student's Address Line1 :");
            string AddressLine1 = Console.ReadLine();
            Console.WriteLine("Enter the student's Address Line2 :");
            string AddressLine2 = Console.ReadLine();
            Console.WriteLine("Enter the student's city :");
            string City = Console.ReadLine();
            Console.WriteLine("Enter the student's state:");
            string State = Console.ReadLine();
            Console.WriteLine("Enter the student's Zip :");
            string Zip = Console.ReadLine();
            Console.WriteLine("Enter the student's Country :");
            string Country = Console.ReadLine();

            PrintStudentInformation(firstName, lastName, BirthDate, AddressLine1, AddressLine2, City, State, Zip, Country);
        }


        static void PrintStudentInformation
            (string fn, string ln, DateTime dob, string ad1, string ad2, string cty, string st,string zip, string cou)
        {
            Console.WriteLine($"The Student info is: \n Name: {fn} {ln} \n DOB: {dob} \n " +
                $"Address: {ad1} {ad2} \n City: {cty} \n State: {st} \n Zip: {zip} \n Country: {cou} ");
        }

        static void GetTeacherInformation()
        {
            Console.WriteLine("Enter the teacher's first name :");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name :");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter teacher's date-of-birth :");
            DateTime BirthDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter the teacher's Address Line1 :");
            string AddressLine1 = Console.ReadLine();
            Console.WriteLine("Enter the teacher's Address Line2 :");
            string AddressLine2 = Console.ReadLine();
            Console.WriteLine("Enter the teacher's city :");
            string City = Console.ReadLine();
            Console.WriteLine("Enter the teacher's state:");
            string State = Console.ReadLine();
            Console.WriteLine("Enter the teacher's Zip :");
            string Zip = Console.ReadLine();
            Console.WriteLine("Enter the teacher's Country :");
            string Country = Console.ReadLine();

            PrintTeacherInformation(firstName, lastName, BirthDate, AddressLine1, AddressLine2, City, State, Zip, Country);
        }

        static void PrintTeacherInformation(string fn, string ln, DateTime birthday, string ad1, 
            string ad2, string ct, string st,string zip, string cty)
        {
            Console.WriteLine($"The teacher info is: \n Name: {fn} {ln} \n DOB: {birthday} \n Address: {ad1} {ad2} \n" +
                $" City: {ct} \n State: {st} \n Zip:{zip} \n Country: {cty} ");
        }
        
    }
}
