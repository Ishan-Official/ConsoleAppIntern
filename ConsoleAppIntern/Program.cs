using System;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n=== Assignment 6 Menu ===");
            Console.WriteLine("1. Print Multiplication Tables (1-10)");
            Console.WriteLine("2. Number Guessing Game (1-100)");
            Console.WriteLine("3. Sum of Even Numbers (1-100)");
            Console.WriteLine("4. Pattern Printing");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option (1-5): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PrintMultiplicationTables();
                    break;
                case "2":
                    NumberGuessingGame();
                    break;
                case "3":
                    SumEvenNumbers();
                    break;
                case "4":
                    PatternPrinting();
                    break;
                case "5":
                    exit = true;
                    Console.WriteLine("Exiting program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    // === 1. Multiplication Tables (1-10) ===
    static void PrintMultiplicationTables()
    {
        Console.WriteLine("\n--- Multiplication Tables (1-10) ---");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"\nTable of {i}:");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
        }
    }

    // === 2. Number Guessing Game ===
    static void NumberGuessingGame()
    {
        Random rand = new Random();
        int secretNumber = rand.Next(1, 101);
        int attempts = 0;
        bool guessed = false;

        Console.WriteLine("\n--- Number Guessing Game ---");
        Console.WriteLine("Guess the number between 1 and 100!");

        while (!guessed)
        {
            Console.Write("Enter your guess: ");
            if (int.TryParse(Console.ReadLine(), out int guess))
            {
                attempts++;
                if (guess == secretNumber)
                {
                    Console.WriteLine($"🎉 Correct! You guessed it in {attempts} attempts.");
                    guessed = true;
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else
                {
                    Console.WriteLine("Too high! Try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

    // === 3. Sum of Even Numbers ===
    static void SumEvenNumbers()
    {
        int sum = 0;
        for (int i = 2; i <= 100; i += 2)
        {
            sum += i;
        }
        Console.WriteLine($"\nSum of even numbers between 1 and 100: {sum}");
    }

    // === 4. Pattern Printing ===
    static void PatternPrinting()
    {
        Console.WriteLine("\n--- Pattern Printing ---");
        Console.WriteLine("1. Right-Angled Triangle");
        Console.WriteLine("2. Diamond");
        Console.Write("Choose a pattern (1-2): ");
        string choice = Console.ReadLine();

        Console.Write("Enter number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case "1":
                for (int i = 1; i <= rows; i++)
                {
                    Console.WriteLine(new string('*', i));
                }
                break;

            case "2":
                // Upper part
                for (int i = 1; i <= rows; i++)
                {
                    Console.Write(new string(' ', rows - i));
                    Console.WriteLine(new string('*', 2 * i - 1));
                }
                // Lower part
                for (int i = rows - 1; i >= 1; i--)
                {
                    Console.Write(new string(' ', rows - i));
                    Console.WriteLine(new string('*', 2 * i - 1));
                }
                break;

            default:
                Console.WriteLine("Invalid pattern choice.");
                break;
        }
    }
}




//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        bool exit = false;

//        while (!exit)
//        {
//            Console.WriteLine("\n=== Assignment 5 Menu ===");
//            Console.WriteLine("1. Grade Calculator");
//            Console.WriteLine("2. Rock, Paper, Scissors");
//            Console.WriteLine("3. Exit");
//            Console.Write("Choose an option (1-3): ");
//            string choice = Console.ReadLine();

//            switch (choice)
//            {
//                case "1":
//                    GradeCalculator();
//                    break;
//                case "2":
//                    RockPaperScissors();
//                    break;
//                case "3":
//                    exit = true;
//                    Console.WriteLine("Exiting program. Goodbye!");
//                    break;
//                default:
//                    Console.WriteLine("Invalid option. Please try again.");
//                    break;
//            }
//        }
//    }

//    // === Grade Calculator ===
//    static void GradeCalculator()
//    {
//        Console.Write("\nEnter numeric score (0-100): ");
//        if (int.TryParse(Console.ReadLine(), out int score) && score >= 0 && score <= 100)
//        {
//            char grade;
//            if (score >= 90) grade = 'A';
//            else if (score >= 80) grade = 'B';
//            else if (score >= 70) grade = 'C';
//            else if (score >= 60) grade = 'D';
//            else grade = 'F';

//            Console.WriteLine($"Score: {score} → Grade: {grade}");
//        }
//        else
//        {
//            Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
//        }
//    }

//    // === Rock, Paper, Scissors Game ===
//    static void RockPaperScissors()
//    {
//        string[] options = { "rock", "paper", "scissors" };
//        Random rand = new Random();

//        Console.Write("\nEnter your choice (rock, paper, scissors): ");
//        string playerChoice = Console.ReadLine().Trim().ToLower();

//        if (Array.Exists(options, choice => choice == playerChoice))
//        {
//            string computerChoice = options[rand.Next(0, 3)];
//            Console.WriteLine($"Computer chose: {computerChoice}");

//            if (playerChoice == computerChoice)
//            {
//                Console.WriteLine("It's a tie!");
//            }
//            else if ((playerChoice == "rock" && computerChoice == "scissors") ||
//                     (playerChoice == "scissors" && computerChoice == "paper") ||
//                     (playerChoice == "paper" && computerChoice == "rock"))
//            {
//                Console.WriteLine("You win!");
//            }
//            else
//            {
//                Console.WriteLine("You lose!");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Invalid choice. Please enter rock, paper, or scissors.");
//        }
//    }
//}




//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        bool exit = false;

//        while (!exit)
//        {
//            Console.WriteLine("\n=== Simple Calculator ===");
//            Console.WriteLine("1. Add");
//            Console.WriteLine("2. Subtract");
//            Console.WriteLine("3. Multiply");
//            Console.WriteLine("4. Divide");
//            Console.WriteLine("5. Compound Interest");
//            Console.WriteLine("6. Exit");
//            Console.Write("Choose an option (1-6): ");

//            string choice = Console.ReadLine();

//            switch (choice)
//            {
//                case "1":
//                    PerformOperation("add");
//                    break;
//                case "2":
//                    PerformOperation("subtract");
//                    break;
//                case "3":
//                    PerformOperation("multiply");
//                    break;
//                case "4":
//                    PerformOperation("divide");
//                    break;
//                case "5":
//                    CalculateCompoundInterest();
//                    break;
//                case "6":
//                    exit = true;
//                    Console.WriteLine("Exiting... Goodbye!");
//                    break;
//                default:
//                    Console.WriteLine("Invalid option. Please try again.");
//                    break;
//            }
//        }
//    }

//    // Perform basic arithmetic
//    static void PerformOperation(string operation)
//    {
//        Console.Write("Enter first number: ");
//        double num1 = Convert.ToDouble(Console.ReadLine());

//        Console.Write("Enter second number: ");
//        double num2 = Convert.ToDouble(Console.ReadLine());

//        switch (operation)
//        {
//            case "add":
//                Console.WriteLine($"Result: {num1 + num2}");
//                break;
//            case "subtract":
//                Console.WriteLine($"Result: {num1 - num2}");
//                break;
//            case "multiply":
//                Console.WriteLine($"Result: {num1 * num2}");
//                break;
//            case "divide":
//                if (num2 == 0)
//                {
//                    Console.WriteLine("Error: Division by zero is not allowed.");
//                }
//                else
//                {
//                    Console.WriteLine($"Result: {num1 / num2}");
//                }
//                break;
//        }
//    }

//    // Compound interest calculation: A = P(1 + r/n)^(nt)
//    static void CalculateCompoundInterest()
//    {
//        Console.Write("Enter Principal amount (P): ");
//        double P = Convert.ToDouble(Console.ReadLine());

//        Console.Write("Enter Annual Interest Rate in % (r): ");
//        double r = Convert.ToDouble(Console.ReadLine()) / 100;

//        Console.Write("Enter Number of times interest applied per year (n): ");
//        int n = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Enter Time in years (t): ");
//        double t = Convert.ToDouble(Console.ReadLine());

//        double A = P * Math.Pow((1 + r / n), n * t);

//        Console.WriteLine($"Compound Interest Amount (A): {A:F2}");
//    }
//}



//using System;

//namespace PersonalInfoCollector
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Ask for user's name
//            Console.Write("Enter your name: ");
//            string name = Console.ReadLine();

//            // Ask for user's age
//            Console.Write("Enter your age: ");
//            int age = Convert.ToInt32(Console.ReadLine());

//            // Ask for user's city
//            Console.Write("Enter your city: ");
//            string city = Console.ReadLine();

//            // Ask for user's favorite hobby
//            Console.Write("Enter your favorite hobby: ");
//            string hobby = Console.ReadLine();

//            // Calculate birth year (Bonus)
//            int currentYear = DateTime.Now.Year;
//            int birthYear = currentYear - age;

//            // Display a formatted summary using string interpolation
//            Console.WriteLine("\n--- Personal Information Summary ---");
//            Console.WriteLine($"Hello, {name}! You are {age} years old, live in {city}, and love {hobby}.");
//            Console.WriteLine($"Based on your age, your estimated birth year is {birthYear}.");

//            // Keep console open
//            Console.WriteLine("\nPress any key to exit...");
//            Console.ReadKey();
//        }
//    }
//}






//using System;

//namespace Assignment1byKhadga { 
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");
//            Console.WriteLine("My name is Khadga bahadur pariyar. I have completed my bachelor of software Engineering  from pokhara university." +
//                " I am passionate about software development and eager to learn more.");

//        }
//    }

//}






//using System;
//namespace Assignment2byKhadga
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            // Variable declaration of different data types

//            // integer type
//            int empAge = 25;

//            // string type
//            string empName = "Ishan";

//            // float type
//            float  empSalary = 50000.50f;

//            // double type
//            double empGpa = 3.75;

//            // char type
//            char empGrade = 'A';

//            // boolean type

//            bool isEmployed = true;

//            // datetime type
//            DateTime empJoiningDate = new DateTime(2025, 9, 5);

//            // calculate joining days

//            TimeSpan joiningDays = DateTime.Now - empJoiningDate;

//            // extract total days from timespan in  Amnil Technology
//            double totalDays = joiningDays.TotalDays;

//            //display employee information

//            Console.WriteLine("Employee Information");
//            Console.WriteLine("---------------------");
//            Console.WriteLine($"Name: {empName}");
//            Console.WriteLine($"Age: {empAge}");
//            Console.WriteLine($"Salary: {empSalary}");
//            Console.WriteLine($"GPA: {empGpa}");
//            Console.WriteLine($"Grade: {empGrade}");
//            Console.WriteLine($"Employed: {isEmployed}");
//            Console.WriteLine($"Joining Date: {empJoiningDate.ToShortDateString()}");
//            Console.WriteLine($"Total Days in Amnil Technology: {totalDays}");

//        }
//    }
//}
