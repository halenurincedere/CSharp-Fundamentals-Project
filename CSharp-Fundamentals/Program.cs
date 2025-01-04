using System;

namespace LumiApplication
{
    class Program
    {
        static void Main()
        {
            ShowMenu(); // ShowMenu method is called to display the main menu.
        }
        static void ShowMenu() // The main menu is displayed.
        {
            while (true)
            {
                Console.Clear(); // Clear the console screen.
                Console.WriteLine("Lumi Application\n----------------------------------");
                Console.WriteLine("\nChoose a feature:\n1. Random Number Guessing Game\n2. Simple Calculator\n3. Letter Grade Average Calculator\n4. Exit");
                Console.Write("Enter your choice: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        PlayGuessingGame();
                        break;
                    case "2":
                        SimpleCalculator();
                        break;
                    case "3":
                        LetterGradedAverage();
                        break;
                    case "4":
                        ExitApplication();
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.\nProcessing...");
                        Task.Delay(1000).Wait(); // 1000 ms = 1 seconds
                        break;
                }
            }
        }
        static void PlayGuessingGame() // The Random Number Guessing Game is played.
        {
            Console.Clear();
            int rndNumber = new Random().Next(0, 101), attempt = 1; // Random number is generated between 0 and 100.

            Console.WriteLine("\nLumi: I'm thinking of a number between 1 and 100. You have 5 attempts to guess it. Good luck!");
            while (attempt <= 5)
            {
                Console.Write($"Attempt {attempt}: Enter your guess (1-100): "); // Shows you how many lives you have after each guess.
                if (int.TryParse(Console.ReadLine(), out int guess) && guess >= 1 && guess <= 100) // Check if the input is valid.
                {
                    if (guess == rndNumber)
                    {
                        Console.WriteLine($"Congratulations! You guessed it on your {attempt} attempt.");
                        break; // If the guess is correct, it exits the loop.
                    }
                    Console.WriteLine(guess < rndNumber
                        ? "You should have guessed a larger number."
                        : "You should have guessed a smaller number."); // Ternary operator.
                    attempt++;
                }
                else // If the input is invalid, display an error message.
                {
                    Console.WriteLine("Invalid input! Please enter a number between 1 and 100.");
                }
            }

            if (attempt > 5)
                Console.WriteLine($"You are out of attempts. The correct number was: {rndNumber}"); // If the user runs out of attempts.
                ShowEndOptions();
        }
        static void SimpleCalculator() 
        {
            Console.Clear();
            Console.WriteLine("\nLumi's Simple Calculator\n-----------------------------------------");

            double num1 = GetValidNumber("Enter the first number: ");
            double num2 = GetValidNumber("Enter the second number: "); // GetvalidNumber method is called to get a valid number. Control is returned when a valid number is entered.

            Console.Write("Choose an operation (+, -, *, /): ");
            string? operation = Console.ReadLine();

            double result = 0; // The result of the operation will be stored in this variable.
            bool validOperation = true; // This variable is used to check if the operation is valid.

            switch (operation) 
                {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                break;
                case "*":
                     result = num1 * num2;
                break;
                case "/":
                    if (num2 == 0)
                     {
                     Console.WriteLine("Error: Division by zero is not allowed.");
                     validOperation = false;
                     }
                    else
                    {
                    result = num1 / num2;
                    }
                    break;
                default:
                Console.WriteLine("Invalid operation.");
                validOperation = false;
                break;
                }
                if (validOperation)
                Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
                ShowEndOptions();
        }
        static double GetValidNumber(string message)
        {
             while (true)
            {
               Console.Write(message);
             if (double.TryParse(Console.ReadLine(), out double number))
                 return number;

                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
        }
        static void LetterGradedAverage()
        {
            Console.Clear();
            Console.WriteLine("\nLumi: Letter Grade Average Calculator\n-----------------------------------------");
            double grade1 = GetValidGrade("Enter 1st grade (0-100): ");
            double grade2 = GetValidGrade("Enter 2nd grade (0-100): ");
            double grade3 = GetValidGrade("Enter 3rd grade (0-100): ");
            double average = Math.Round((grade1 + grade2 + grade3) / 3, 1); // Math.Round method is used to round the average to one decimal place.

            string letterGrade = DetermineLetterGrade(average);
            Console.WriteLine($"Average: {average} Letter Grade: {letterGrade}");

            ShowEndOptions();
        }
        static double GetValidGrade(string message) // This method is used to get a valid grade from the user. The grade must be between 0 and 100.
        {
            while (true)
            {
                Console.Write(message);
                if (double.TryParse(Console.ReadLine(), out double grade) && grade >= 0 && grade <= 100)
                    return grade;

                Console.WriteLine("Invalid input! Please enter a number between 0 and 100.");
            }
        }
        static string DetermineLetterGrade(double average)
        {
            if (average >= 90) return "AA";
            else if (average >= 85) return "BA";
            else if (average >= 80) return "BB";
            else if (average >= 75) return "CB";
            else if (average >= 70) return "CC";
            else if (average >= 65) return "DC";
            else if (average >= 60) return "DD";
            else if (average >= 55) return "FD";
            else return "FF";
        }
        static void ShowEndOptions()
        {
            Console.WriteLine("\n1. Return to Main Menu\n2. Exit");
            Console.Write("Enter your choice: ");
            switch (Console.ReadLine())
            {
                case "1":
                    return; // Return to the main menu
                case "2":
                    ExitApplication();
                    break;
                default: // If the input is invalid, display an error message.
                    Console.WriteLine("Invalid choice. Try again.");
                    Task.Delay(1000).Wait(); // 1000 ms = 1 seconds
                    Console.Clear();
                    ShowEndOptions();
                    break;
            }
        }
        static void ExitApplication() // The application is terminated.
        {
            Console.WriteLine("Thank you for using Lumi Application. Goodbye!");
            Environment.Exit(0); // Exit the application
        }
    }
}