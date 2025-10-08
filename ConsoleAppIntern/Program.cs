
using System;

namespace Assignment11
{
    // Car class definition
    class Car
    {
        // Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        // Constructor
        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        // Methods
        public void Start()
        {
            Console.WriteLine($"{Make} {Model} is starting...");
        }

        public void Stop()
        {
            Console.WriteLine($"{Make} {Model} has stopped.");
        }

        public void Accelerate()
        {
            Console.WriteLine($"{Make} {Model} is accelerating!");
        }

        public void GetInfo()
        {
            Console.WriteLine($"Car Info: {Year} {Color} {Make} {Model}");
        }
    }

    // Book class definition
    class Book
    {
        // Properties
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsAvailable { get; set; }

        // Constructor
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            IsAvailable = true; // default to available
        }

        // Methods
        public void Borrow()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"You have borrowed \"{Title}\" by {Author}.");
            }
            else
            {
                Console.WriteLine($"Sorry, \"{Title}\" is not available right now.");
            }
        }

        public void ReturnBook()
        {
            IsAvailable = true;
            Console.WriteLine($"You have returned \"{Title}\".");
        }

        public void DisplayInfo()
        {
            string status = IsAvailable ? "Available" : "Not Available";
            Console.WriteLine($"Book Info: \"{Title}\" by {Author}, ISBN: {ISBN}, Status: {status}");
        }
    }

    // Main program to test the classes
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Car Class Demo ===");
            Car car1 = new Car("Toyota", "Corolla", 2021, "Red");
            Car car2 = new Car("Tesla", "Model 3", 2024, "Black");

            car1.Start();
            car1.Accelerate();
            car1.GetInfo();
            car1.Stop();

            Console.WriteLine();

            car2.Start();
            car2.Accelerate();
            car2.GetInfo();
            car2.Stop();

            Console.WriteLine("\n=== Book Class Demo ===");
            Book book1 = new Book("The Alchemist", "Paulo Coelho", "978-0061122415");
            Book book2 = new Book("1984", "George Orwell", "978-0451524935");

            book1.DisplayInfo();
            book2.DisplayInfo();

            book1.Borrow();
            book1.DisplayInfo();

            book1.ReturnBook();
            book1.DisplayInfo();

            Console.WriteLine("\nProgram completed successfully!");
        }
    }
}




//using System;

//namespace StudentGradeManagementSystem
//{
//    class Program
//    {
//        // Maximum number of students allowed
//        const int MAX_STUDENTS = 50;

//        // Arrays to store student names and grades
//        static string[] studentNames = new string[MAX_STUDENTS];
//        static double[,] studentGrades = new double[MAX_STUDENTS, 5]; // max 5 subjects
//        static int studentCount = 0;

//        static void Main(string[] args)
//        {
//            int choice;

//            do
//            {
//                Console.Clear();
//                Console.WriteLine("=== Student Grade Management System ===");
//                Console.WriteLine("1. Add Student");
//                Console.WriteLine("2. Enter Grades");
//                Console.WriteLine("3. Calculate Average");
//                Console.WriteLine("4. Display Report");
//                Console.WriteLine("5. Exit");
//                Console.Write("Enter your choice: ");

//                // Input validation
//                if (!int.TryParse(Console.ReadLine(), out choice))
//                {
//                    Console.WriteLine("Invalid input. Please enter a number.");
//                    Console.ReadKey();
//                    continue;
//                }

//                switch (choice)
//                {
//                    case 1:
//                        AddStudent();
//                        break;
//                    case 2:
//                        EnterGrades();
//                        break;
//                    case 3:
//                        CalculateAverage();
//                        break;
//                    case 4:
//                        DisplayReport();
//                        break;
//                    case 5:
//                        Console.WriteLine("Exiting... Goodbye!");
//                        break;
//                    default:
//                        Console.WriteLine("Invalid choice. Try again.");
//                        break;
//                }

//                if (choice != 5)
//                {
//                    Console.WriteLine("\nPress any key to return to the menu...");
//                    Console.ReadKey();
//                }

//            } while (choice != 5);
//        }

//        // Add new student
//        static void AddStudent()
//        {
//            if (studentCount >= MAX_STUDENTS)
//            {
//                Console.WriteLine("Maximum student limit reached!");
//                return;
//            }

//            Console.Write("Enter student name: ");
//            string name = Console.ReadLine();

//            if (string.IsNullOrWhiteSpace(name))
//            {
//                Console.WriteLine("Name cannot be empty.");
//                return;
//            }

//            studentNames[studentCount] = name;
//            studentCount++;
//            Console.WriteLine($"Student '{name}' added successfully.");
//        }

//        // Enter grades for a student
//        static void EnterGrades()
//        {
//            if (studentCount == 0)
//            {
//                Console.WriteLine("No students available. Please add a student first.");
//                return;
//            }

//            Console.Write("Enter student index (0 - " + (studentCount - 1) + "): ");
//            if (!int.TryParse(Console.ReadLine(), out int index) || index < 0 || index >= studentCount)
//            {
//                Console.WriteLine("Invalid student index.");
//                return;
//            }

//            Console.WriteLine($"Entering grades for {studentNames[index]}:");

//            for (int i = 0; i < 5; i++)
//            {
//                Console.Write($"Enter grade for subject {i + 1} (0-100, or -1 to skip): ");
//                if (!double.TryParse(Console.ReadLine(), out double grade) || grade < -1 || grade > 100)
//                {
//                    Console.WriteLine("Invalid grade. Please enter a number between 0-100, or -1 to skip.");
//                    i--; // retry
//                    continue;
//                }

//                if (grade == -1) break; // stop entering grades
//                studentGrades[index, i] = grade;
//            }
//        }

//        // Calculate average grade for each student
//        static void CalculateAverage()
//        {
//            if (studentCount == 0)
//            {
//                Console.WriteLine("No students available.");
//                return;
//            }

//            Console.WriteLine("=== Student Averages ===");
//            for (int i = 0; i < studentCount; i++)
//            {
//                double total = 0;
//                int count = 0;

//                for (int j = 0; j < 5; j++)
//                {
//                    if (studentGrades[i, j] > 0)
//                    {
//                        total += studentGrades[i, j];
//                        count++;
//                    }
//                }

//                double average = count > 0 ? total / count : 0;
//                Console.WriteLine($"{studentNames[i]} - Average: {average:F2}");
//            }
//        }

//        // Display student report with grades
//        static void DisplayReport()
//        {
//            if (studentCount == 0)
//            {
//                Console.WriteLine("No students available.");
//                return;
//            }

//            Console.WriteLine("=== Student Report ===");
//            for (int i = 0; i < studentCount; i++)
//            {
//                Console.Write($"{i}. {studentNames[i]} - Grades: ");
//                for (int j = 0; j < 5; j++)
//                {
//                    if (studentGrades[i, j] > 0)
//                        Console.Write(studentGrades[i, j] + " ");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}




//using System;

//namespace StringUtilitiesApp
//{
//    // ✅ Utility class containing string helper methods
//    public static class StringUtilities
//    {
//        // Count words in a string
//        public static int CountWords(string input)
//        {
//            if (string.IsNullOrWhiteSpace(input))
//                return 0;

//            string[] words = input.Split(new char[] { ' ', '\t', '\n' },
//                                          StringSplitOptions.RemoveEmptyEntries);
//            return words.Length;
//        }

//        // Reverse a string
//        public static string ReverseString(string input)
//        {
//            if (string.IsNullOrEmpty(input))
//                return input;

//            char[] charArray = input.ToCharArray();
//            Array.Reverse(charArray);
//            return new string(charArray);
//        }

//        // Check if a string is a palindrome
//        public static bool IsPalindrome(string input)
//        {
//            if (string.IsNullOrEmpty(input))
//                return false;

//            string cleaned = RemoveSpaces(input).ToLower();
//            string reversed = ReverseString(cleaned);
//            return cleaned == reversed;
//        }

//        // Remove spaces from a string
//        public static string RemoveSpaces(string input)
//        {
//            return string.IsNullOrEmpty(input) ? input : input.Replace(" ", "");
//        }
//    }

//    // ✅ Example usage / refactor previous assignments
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== String Utilities Demo ===");

//            string text = "  Hello world from DotNet Core 9  ";
//            Console.WriteLine($"Original: '{text}'");

//            Console.WriteLine($"Word Count: {StringUtilities.CountWords(text)}");
//            Console.WriteLine($"Reversed: {StringUtilities.ReverseString(text)}");
//            Console.WriteLine($"Is Palindrome (\"madam\"): {StringUtilities.IsPalindrome("madam")}");
//            Console.WriteLine($"Remove Spaces: '{StringUtilities.RemoveSpaces(text)}'");

//            // ✅ Example of refactoring: reusing methods
//            string palindromeTest = "Never odd or even";
//            Console.WriteLine($"Is \"{palindromeTest}\" palindrome? {StringUtilities.IsPalindrome(palindromeTest)}");
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
//            Console.WriteLine("\n=== Assignment 6 Menu ===");
//            Console.WriteLine("1. Print Multiplication Tables (1-10)");
//            Console.WriteLine("2. Number Guessing Game (1-100)");
//            Console.WriteLine("3. Sum of Even Numbers (1-100)");
//            Console.WriteLine("4. Pattern Printing");
//            Console.WriteLine("5. Exit");
//            Console.Write("Choose an option (1-5): ");

//            string choice = Console.ReadLine();

//            switch (choice)
//            {
//                case "1":
//                    PrintMultiplicationTables();
//                    break;
//                case "2":
//                    NumberGuessingGame();
//                    break;
//                case "3":
//                    SumEvenNumbers();
//                    break;
//                case "4":
//                    PatternPrinting();
//                    break;
//                case "5":
//                    exit = true;
//                    Console.WriteLine("Exiting program. Goodbye!");
//                    break;
//                default:
//                    Console.WriteLine("Invalid choice. Try again.");
//                    break;
//            }
//        }
//    }

//    // === 1. Multiplication Tables (1-10) ===
//    static void PrintMultiplicationTables()
//    {
//        Console.WriteLine("\n--- Multiplication Tables (1-10) ---");
//        for (int i = 1; i <= 10; i++)
//        {
//            Console.WriteLine($"\nTable of {i}:");
//            for (int j = 1; j <= 10; j++)
//            {
//                Console.WriteLine($"{i} x {j} = {i * j}");
//            }
//        }
//    }

//    // === 2. Number Guessing Game ===
//    static void NumberGuessingGame()
//    {
//        Random rand = new Random();
//        int secretNumber = rand.Next(1, 101);
//        int attempts = 0;
//        bool guessed = false;

//        Console.WriteLine("\n--- Number Guessing Game ---");
//        Console.WriteLine("Guess the number between 1 and 100!");

//        while (!guessed)
//        {
//            Console.Write("Enter your guess: ");
//            if (int.TryParse(Console.ReadLine(), out int guess))
//            {
//                attempts++;
//                if (guess == secretNumber)
//                {
//                    Console.WriteLine($"🎉 Correct! You guessed it in {attempts} attempts.");
//                    guessed = true;
//                }
//                else if (guess < secretNumber)
//                {
//                    Console.WriteLine("Too low! Try again.");
//                }
//                else
//                {
//                    Console.WriteLine("Too high! Try again.");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Invalid input. Please enter a number.");
//            }
//        }
//    }

//    // === 3. Sum of Even Numbers ===
//    static void SumEvenNumbers()
//    {
//        int sum = 0;
//        for (int i = 2; i <= 100; i += 2)
//        {
//            sum += i;
//        }
//        Console.WriteLine($"\nSum of even numbers between 1 and 100: {sum}");
//    }

//    // === 4. Pattern Printing ===
//    static void PatternPrinting()
//    {
//        Console.WriteLine("\n--- Pattern Printing ---");
//        Console.WriteLine("1. Right-Angled Triangle");
//        Console.WriteLine("2. Diamond");
//        Console.Write("Choose a pattern (1-2): ");
//        string choice = Console.ReadLine();

//        Console.Write("Enter number of rows: ");
//        int rows = Convert.ToInt32(Console.ReadLine());

//        switch (choice)
//        {
//            case "1":
//                for (int i = 1; i <= rows; i++)
//                {
//                    Console.WriteLine(new string('*', i));
//                }
//                break;

//            case "2":
//                // Upper part
//                for (int i = 1; i <= rows; i++)
//                {
//                    Console.Write(new string(' ', rows - i));
//                    Console.WriteLine(new string('*', 2 * i - 1));
//                }
//                // Lower part
//                for (int i = rows - 1; i >= 1; i--)
//                {
//                    Console.Write(new string(' ', rows - i));
//                    Console.WriteLine(new string('*', 2 * i - 1));
//                }
//                break;

//            default:
//                Console.WriteLine("Invalid pattern choice.");
//                break;
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
