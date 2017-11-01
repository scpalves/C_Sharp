using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Three_Self_Assesment_Lab
{
    class Program
    {
        static void Main(string[] args)
        {

            GetStudentInformation(out string firstName,out string lastName,out DateTime birth);
            PrintStudentDetails(firstName,lastName,birth.ToLongDateString().ToString());
            
            // revenge from calling method that doesn't have any content.
            try
            {
                System.DateTime? test;
                test = new System.DateTime(2013, 04, 22);

                ValidatingStudentBirthday(ref test);
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("ValidatingStudentBirthday is under maintain.");
            }
            // Implement code above.
            Console.ReadKey();
        }

        static void GetStudentInformation(out string firstName, out string lastName, out DateTime birth)
        {
            Console.WriteLine("Enter the student's first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name: ");
            lastName = Console.ReadLine();

            // Code to finish getting the rest of the student data
            //....................................................

            Console.WriteLine("Enter the student's birthday (dd/mm/yyyy or dd-mm-yyyy): ");
            string birthday = Console.ReadLine();
            if(DateTime.TryParse(birthday,out birth)) {}
            else
            {
                Console.WriteLine($"Unable to convert '{birthday}' to a date.");
            }
        }

        static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }

        static DateTime ValidatingStudentBirthday(ref DateTime? test)
        {
            throw new NotImplementedException();
        }
        // Implement method like teacher , course or program above this line. You can make another method like 2 method above.
    }
}
