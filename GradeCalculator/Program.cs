using System;

class GradeCalculator
{
    static void Main()
    {
        bool keepRunning = true;

        while (keepRunning)
        {
            try
            {
                Console.Write("Enter your numerical grade (0-100): ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int grade))
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                    continue;
                }

                if (grade < 0 || grade > 100)
                {
                    Console.WriteLine("The grade must be between 0 and 100.");
                    continue;
                }

                string letterGrade;

                if (grade >= 90) letterGrade = "A";
                else if (grade >= 80) letterGrade = "B";
                else if (grade >= 70) letterGrade = "C";
                else if (grade >= 60) letterGrade = "D";
                else letterGrade = "F";

                Console.WriteLine($"Your letter grade is: {letterGrade}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }

            Console.Write("\nEnter 1 to try again, or any other key to exit: ");
            string response = Console.ReadLine().Trim();

            if (response != "1")
            {
                keepRunning = false;
                Console.WriteLine("Thanks for stoppping by");
            }
            Console.WriteLine();
        }
    }
}
