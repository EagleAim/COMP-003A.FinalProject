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
            Console.WriteLine("PRESS ENTER TO CONTINUTE");
            Console.WriteLine("".PadRight(50, '*'));

            ///<summary>
            ///Basic Information Section
            /// </summary>



            //FIRST NAME AND LAST NAME
            Console.WriteLine("PLEASE ENTER FIRST NAME");
            string firstName = Console.ReadLine();
            firstName = Console.ReadLine();

            Console.WriteLine("PLEASE ENTER LAST NAME");
            string lastName = Console.ReadLine();
            lastName = Console.ReadLine();

            //AGE
            Console.WriteLine("PLEASE ENTER YOUR BIRTHYEAR");
            string inputAge = Console.ReadLine();
            int yearBorn = DateTime.Now.Year - Convert.ToInt32(inputAge);
            inputAge = Console.ReadLine();

            if (yearBorn >= 1900 && yearBorn <= DateTime.Now.Year)
            {

            }

            else
            {
                Console.WriteLine("\t Invalid Age");
            }



            //GENDER
            Console.WriteLine("PLEASE ENTER YOUR GENDER USING M, F, OR O");
            string inputGender = Console.ReadLine();
            inputGender = Console.ReadLine();

            if (inputGender == "M")
            {
                Console.WriteLine("\tMale");
            }
            else if (inputGender == "F")
            {
                Console.WriteLine("\tFemale");
            }

            else if (inputGender == "O") 
            {
                Console.WriteLine("\tOther not listed");
            }

            else
            {
                Console.WriteLine("\tInvalid Response");
            }


            
            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"Age: {inputAge}");
            Console.WriteLine($"Gender: {inputGender}");
        }
    }
}
