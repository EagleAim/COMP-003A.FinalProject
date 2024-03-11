/*
 * Author: Logan King
 * course: Comp003A
 * Purpouse: To show our skills with C# in a final project.
*/




using System.Runtime.Intrinsics.X86;

namespace COMP_003A.FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("Welcome to Kings County Medical");
            Console.WriteLine("Please enter the apropiate information below to create a account");
            Console.WriteLine("".PadRight(50, '*'));

            ///<summary>
            ///Basic Information Section
            /// </summary>



            //FIRST NAME AND LAST NAME
            Console.WriteLine("\tPLEASE ENTER FIRST NAME");
            string firstName = Console.ReadLine();


            Console.WriteLine("\tPLEASE ENTER LAST NAME");
            string lastName = Console.ReadLine();

            //AGE
            Console.WriteLine("\tPLEASE ENTER YOUR BIRTHYEAR");
            string inputAge = Console.ReadLine();

            int currentYear = DateTime.Now.Year;
            int yearBorn = Convert.ToInt32(inputAge);

            if (yearBorn >= 1900 && yearBorn <= currentYear)
            {
                int currentAge = currentYear - yearBorn;
                yearBorn = currentAge;
                Console.WriteLine($"{currentAge}");
                
            }

            else
            {
                Console.WriteLine("Invalid Age");
                
            }



            //GENDER
            Console.WriteLine("\tPLEASE ENTER YOUR GENDER USING M, F, OR O");
            string inputGender = Console.ReadLine();

            if (string.Equals(inputGender, "m", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("Male");
                var genderDetector = Console.ReadLine();
                inputGender = genderDetector;
            }
            else if (string.Equals(inputGender, "f", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("Female");
                var genderDetector = Console.ReadLine();
                inputGender = genderDetector;
            }
            else if (string.Equals(inputGender, "o", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("Other not listed");
                var genderDetector = Console.ReadLine();
                inputGender = genderDetector;
            }
            else
            {
                Console.WriteLine("Invalid input");
                var genderDetector = Console.ReadLine();
                inputGender = genderDetector;
            }


            // Basic Info Log
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("BASIC INFO");
            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"Age: {yearBorn}");
            Console.WriteLine($"Gender: {inputGender}");
            Console.WriteLine("".PadRight(50, '*'));
        }
    }
}
