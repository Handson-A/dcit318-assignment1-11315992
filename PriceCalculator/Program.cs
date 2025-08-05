using System;

class TicketPriceCalculator
{
    static void Main()
    {
        bool keepRunning = true;

        while (keepRunning)
        {
            try
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int age) || age < 0 || age > 130)
                {
                    Console.WriteLine("Invalid age. Please enter a number between 0 and 130.");
                    continue;
                }

                int price = 10;

                if (age <= 12 || age >= 65)
                    price = 7;

                Console.WriteLine($"Your ticket price is: GHC{price}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred: {ex.Message}");
            }

            Console.Write("\nEnter 1 to check another ticket, or any other key to exit: ");
            string choice = Console.ReadLine().Trim();

            if (choice != "1")
            {
                keepRunning = false;
                Console.WriteLine("Thanks for stopping by");
            }

            Console.WriteLine();
        }
    }
}
