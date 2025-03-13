namespace Conditionals_McCarty_Daniel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter a whole number, please!");
            int myWholeNum = Convert.ToInt32(Console.ReadLine());

            // check if positive or negitive
            if (myWholeNum >= 0) 
            {
                Console.WriteLine($"{myWholeNum} is a positive number!");
            }
            else
            {
                Console.WriteLine($"{myWholeNum} is a negative number!");
            }

            // check if even or odd
            if(myWholeNum % 2 == 0)
            {
                Console.WriteLine($"{myWholeNum} is a even number!");
            }
            else
            {
                Console.WriteLine($"{myWholeNum} is a odd number!");
            }

            // creates two or more integers numbers
            int num1 = 6;
            int num2 = 99;

            // gets first max
            int firstMax = Math.Max(myWholeNum, num1);
            // get maximum number
            int max = Math.Max(firstMax, num2);

            // prints max to console
            Console.WriteLine($"The maximum number of {myWholeNum}, {num1}, and {num2} is {max}!");

            // asks to enter a grade and assigns it to a char variable, grade
            Console.WriteLine("Enter a grade (A, B, C, D, F)!");
            char grade = Console.ReadKey().KeyChar;

            //prints description based on grade value
            switch (grade) 
            {
                case 'A':
                    Console.WriteLine("\nSuperior");
                    break;
                case 'B':
                    Console.WriteLine("\nvery Good");
                    break;
                case 'C':
                    Console.WriteLine("\nAverage");
                    break;
                case 'D':
                    Console.WriteLine("\nBelow Average");
                    break;
                case 'F':
                    Console.WriteLine("\nFail");
                    break;
                default:
                    Console.WriteLine("\nyou did not enter a valid grade!");
                    break;
            }
        }
    }
}