// See https://aka.ms/new-console-template for more information
using System.Diagnostics;


// int add = 0;
// int substract = 0;
// int multiply = 0;
// int division = 0;
List<int> pastScores = new List<int>();
bool playAgain = true;

while(playAgain)
{
    Menu();
    string choice = UserChoices();
    Questions(choice);
    Console.WriteLine("Do you want to play again? (y/n)");
    string answer = Console.ReadLine().Trim().ToLower();

    if (answer != "y")
    {
        playAgain = false;
        Console.WriteLine("Thanks for playing!");
    }
}
void Menu() {
    Console.WriteLine("------------------------------------");
    Console.WriteLine("Hello, Welcome to the Math Game!");
    Console.WriteLine("What is your name?");
    string userName = Console.ReadLine();
    Console.WriteLine($"Hello {userName}, let's start the game!");
    Console.WriteLine("Please choose your choices");

}

string UserChoices()
{
    Console.WriteLine("Choose an operation:");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");

    string choice = Console.ReadLine();
    

    if (choice.Trim() == "1")
    {
        Addition();
    }
    else if (choice.Trim() == "2")
    {
        Subtraction();
    }
    else if (choice.Trim() == "3")
    {
        Multiplication();
    }
    else if (choice.Trim() == "4")
    {
        Division();
    }
    else if (choice.Trim().ToLower() == "q")
    {
        Console.WriteLine("Goodbye");
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine(" Invalid Choice");
    }
    return choice;
}
//creating Choices in switch break cases
// selection 1. - Addition so userInput1 + userInput2
// selection 2. - Subtraction so userInput1 - userInput2
// selection 3. - Multiplication so userInput1 * userInput2
// selection 4. - Division so userInput1 / userInput2

void Questions(string questions)
{
    Random random = new Random();
    int score = 0;
    int timeLimitSeconds = 10;
    for (int i = 0; i < 5; i ++)
    {
    int num1 = random.Next(1, 10);
    int num2 = random.Next(1, 10);
    int correctAnswer = 0;
    switch (questions)
    {
        case "1":
            Console.WriteLine($"What is {num1} + {num2}? ");
            correctAnswer = num1 + num2;
            break;
        case "2":
            Console.WriteLine($"What is {num1} - {num2}? ");
            correctAnswer = num1 - num2;
            break;
        case "3":
            Console.WriteLine($"What is {num1} x {num2}? ");
            correctAnswer = num1 * num2;
            break;
        case "4":
        while (num2 == 0)
        {
            num2 = random.Next(1, 10);
        }
            correctAnswer = num1 / num2;
             Console.WriteLine($"What is {num1} / {num2}? ");
            break;
            
            case "q":
            Console.WriteLine("Goodbye");
            Environment.Exit(1);
            break;
        default:
            Console.WriteLine("Invalid choice");
            Environment.Exit(1);
            break;
    }
    bool timeUp = false;
    //Timer Thread
    Stopwatch stopwatch = Stopwatch.StartNew();
    string input = Console.ReadLine();
    Thread timerThread = new Thread(() =>
        {
            for (int t = timeLimitSeconds; t > 0; t--)
            {
                if (stopwatch.Elapsed.TotalSeconds >= timeLimitSeconds)
                {
                    Console.WriteLine("Time's up!");
                    Console.WriteLine($"The correct answer was {correctAnswer}");
                    continue;
                }
               
                Thread.Sleep(1000);
            }
        });
    timerThread.Start();
    // timerThread.Join();
    stopwatch.Stop();
    
    int userResult;
    bool validInput = int.TryParse(input, out userResult);
    if (validInput && userResult == correctAnswer)
    {
        Console.WriteLine("Your answer is correct");
        score++;

    }
    else
    {
        Console.WriteLine($"Your answer is incorrect! The answer is {correctAnswer}");
    }

    }
    pastScores.Add(score);
    Console.WriteLine($"Game Over! the final scoreis {score} / 5");
    ShowPastScore();

}
void Addition()
{
    Console.WriteLine(" Addition Selected");
}
void Subtraction()
{
    Console.WriteLine(" Subtraction Selected");
}
void Multiplication()
{
    Console.WriteLine(" Multiplication Selected");
}
void Division()
{
    Console.WriteLine(" Division Selected");
}

void ShowPastScore()
{
    bool seeScore = true;
    while (seeScore)
    {
        Console.WriteLine("Do you want to see your past scores? (y/n)");
        string input = Console.ReadLine();
        if (input == "y")
        {
            Console.WriteLine("\n Past Scores:");
            for (int i = 0; i < pastScores.Count; i++)
            {
                Console.WriteLine($"Game {i + 1}: {pastScores[i]} / 5");
            }
        }
        else if (input == "n")
        {
            seeScore = false;
            return;
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}
