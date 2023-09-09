using System;

namespace SimpleCalculator;

class Program {
    static void Main(string[] args)
    {
        RunCalculator();
    }

    private static void RunCalculator()
    {   
        Console.WriteLine("Simple Calculator");
        while (true)
        {
            Console.WriteLine("Please Choose the Option");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option (1-5): ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
            {
                Console.WriteLine("Invalid choice. Please select again.");
                continue;
            }

            double num1;
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid Value of Number. Please try again.");
                continue;
            }

            double num2;
            if (!double.TryParse(Console.ReadLine(), out num2))
            { 
                Console.WriteLine("Invalid Value of Number. Please try again.");
                continue;
            }

            switch(choice)
            {
                case 1:
                    Console.WriteLine($"Result: {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"Result: {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"Result: {num1 * num2}");
                    break;
                case 4:
                    if (num2 == 0) {
                        Console.WriteLine("Can not divide on zero");
                        break;
                    }
                    else 
                    {
                        Console.WriteLine($"Result: {num1 / num2}");
                        break;
                    }
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }


}
