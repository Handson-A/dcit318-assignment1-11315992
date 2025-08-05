using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        bool keepRunning = true;

        while (keepRunning)
        {
            try
            {
                Console.WriteLine("Enter the lengths of the three sides of the triangle:");

                Console.Write("Side 1: ");
                if (!int.TryParse(Console.ReadLine(), out int side1) || side1 <= 0)
                {
                    Console.WriteLine(" Invalid input. Please enter a positive number.");
                    continue;
                }

                Console.Write("Side 2: ");
                if (!int.TryParse(Console.ReadLine(), out int side2) || side2 <= 0)
                {
                    Console.WriteLine(" Invalid input. Please enter a positive number.");
                    continue;
                }

                Console.Write("Side 3: ");
                if (!int.TryParse(Console.ReadLine(), out int side3) || side3 <= 0)
                {
                    Console.WriteLine(" Invalid input. Please enter a positive number.");
                    continue;
                }

                // Triangle inequality check
                if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
                {
                    Console.WriteLine(" Invalid triangle: The sides do not satisfy the triangle inequality.");
                    continue;
                }

                // Type determination
                if (side1 == side2 && side2 == side3)
                    Console.WriteLine(" This is an Equilateral triangle.");
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                    Console.WriteLine(" This is an Isosceles triangle.");
                else
                    Console.WriteLine(" This is a Scalene triangle.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            Console.Write("\nEnter 1 to try another set, or any other key to exit: ");
            string choice = Console.ReadLine().Trim();

            if (choice != "1")
            {
                keepRunning = false;
                Console.WriteLine("Thanks");
            }

            Console.WriteLine();
        }
    }
}
