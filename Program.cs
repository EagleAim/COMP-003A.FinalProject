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
            }

            else
            {
                Console.WriteLine("Invalid Age");
            }



            //GENDER
            Console.WriteLine("\tPLEASE ENTER YOUR GENDER USING M, F, OR O");
            string inputGender = Console.ReadLine();
            char charinputGender = Convert.ToChar(inputGender);

            Console.WriteLine(SwitchGender(charinputGender));

            // Basic Info Log
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("BASIC INFO");
            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"Age: {yearBorn}");
            Console.WriteLine($"Gender: {charinputGender}");
            Console.WriteLine("".PadRight(50, '*'));


            /// <summary>
            /// Questionare
            /// </summary>
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("\tQuestionare");
            Console.WriteLine("Please fill to the best of your ability to log what is needed foryour health");
            Console.WriteLine("".PadRight(50, '*'));


            List<string> PaitentInfo = new List<string>();

            //question 1
            Console.WriteLine("Question 1: Please enter all medication you are taking, or press e if you have none");
            string input = Console.ReadLine();
            PaitentInfo.Add(input);

            var Exit = "e";

            do
            {
                while (input != "")
                {
                    Console.WriteLine("Please add more medication or press 'e' to go to the next question: ");
                    input = Console.ReadLine();
                }

                if (input == Exit)
                {
                    break;
                }
            } while (input != Exit);


            //question 2
            Console.WriteLine("Question 2: Please enter all insurance you have, or press e if you have none");
            string input1 = Console.ReadLine();
            PaitentInfo.Add(input1);

            var Exit1 = "e";

            do
            {
                while (input1 != "")
                {
                    Console.WriteLine("Please add more insurances or press 'e' to go to the next question: ");
                    input = Console.ReadLine();
                }

                if (input1 == Exit1)
                {
                    break;
                }
            } while (input1 != Exit1);

            //question 3
            Console.WriteLine("Question 3: Please enter all diagnosed medical issues you have, or press e if you have none");
            string input2 = Console.ReadLine();
            PaitentInfo.Add(input2);

            var Exit2 = "e";

            do
            {
                while (input2 != "")
                {
                    Console.WriteLine("Please add more issues or press 'e' to go to the next question: ");
                    input = Console.ReadLine();
                }

                if (input2 == Exit2)
                {
                    break;
                }
            } while (input2 != Exit2);

            //question 4
            Console.WriteLine("Question 4: Please enter all unprescribed medications and drugs you have taken within the last month, or press e if you have none");
            string input3 = Console.ReadLine();
            PaitentInfo.Add(input3);

            var Exit3 = "e";

            do
            {
                while (input3 != "")
                {
                    Console.WriteLine("Please add more mediction and drugs or press 'e' to go to the next question: ");
                    input = Console.ReadLine();
                }

                if (input3 == Exit3)
                {
                    break;
                }
            } while (input3 != Exit3);

            //all the inputs
            Console.WriteLine(PaitentInfo);
            Console.WriteLine("Thank for your information all of this will be sent to our staff, we will contact with your new provider soon. Thank you!");










            ///<summary>
            ///Gender calculator
            /// </summary>
            static string SwitchGender(char input)
            {
                switch (input)
                {
                    case 'M':
                    case 'm':
                        {
                            return "Male";
                        }
                    case 'F':
                    case 'f':
                        {
                            return "Female";
                        }
                    case 'O':
                    case 'o':
                        {
                            return "Other Not Listed";
                        }
                    default:
                        {
                            return "Invalid Input";
                        }
                }
            }
        }
    }
}
