using CalculatorProj;

internal class Program
{
    private static void Main(string[] args)
    {
        Calculator calc = new();
        bool choice = true;


        while (choice)
        {
            //Operation select
            Console.WriteLine("Please enter a number listed to select an operation");
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Subtraction");
            Console.WriteLine("3: Multiplication");
            Console.WriteLine("4: Division");
            Console.WriteLine("5: Percentage Calculation");
            double input = Convert.ToDouble(Console.ReadLine());

            switch(input)
            {
                case 1:
                    Console.WriteLine("You have selected ADDITION");
                    Console.WriteLine("The result is " + Calculator.Add());
                    break;
               case 2:
                    Console.WriteLine("You have selected SUBTRACTION");
                    Console.WriteLine("The result is " + Calculator.Subtract());
                    break;
                case 3:
                    Console.WriteLine("You have selected DIVISION");
                    Console.WriteLine("The result is " + Calculator.Divide());
                    break;
                case 4:
                    Console.WriteLine("You have selected MULTIPLICATION");
                    Console.WriteLine("The result is " + Calculator.Multiply());
                    break;
                case 5:
                    Console.WriteLine("You have selected PERCENTAGE CALC");
                    Console.WriteLine("The result is " + Calculator.Percentage());
                    break;
                default:
                    Console.WriteLine("Option chosen is not a valid input.");
                    break;
            }

            Console.WriteLine("Would you like to retry?");
            Console.WriteLine("1: Yes");
            Console.WriteLine("2: No");

            int retry = Convert.ToInt32(Console.ReadLine());

            if (retry == 1)
                continue;
            else
                Console.WriteLine("Exiting...");
                choice = false;
        }


    }
}