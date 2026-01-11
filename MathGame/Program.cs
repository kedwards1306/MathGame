// See https://aka.ms/new-console-template for more information

int add = 0;
int substract = 0;
int multiply = 0;
int division = 0;

Menu();
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
    return choice;
    
    if (choice.Trim() == "1")
    {
        Console.WriteLine(" Addition Selected");
    }
    else if (choice.Trim() == "2")
    {
        Console.WriteLine(" Subtraction Selected");
    }
    else if (choice.Trim() == "3")
    {
        Console.WriteLine(" Multiplication Selected");
    }
    else if (choice.Trim() == "4")
    {
        Console.WriteLine(" Division Selected");
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
}

//creating Choices in switch break cases
// selection 1. - Addition so userInput1 + userInput2
// selection 2. - Subtraction so userInput1 - userInput2
// selection 3. - Multiplication so userInput1 * userInput2
// selection 4. - Division so userInput1 / userInput2
// selection 5. - could be random or more than one formula

void Questions(string questions)
{
    Random random = new Random();
    int num1 = random.Next(1, 10);
    int num2 = random.Next(1, 10);
    int result;
    switch (questions)
    {
        case "1":
            Console.WriteLine($"What is {num1} + {num2}? ");
            result = num1 + num2;
            break;
        case "2":
            Console.WriteLine($"What is {num1} - {num2}? ");
            result = num1 - num2;
            break;
        case "3":
            Console.WriteLine($"What is {num1} x {num2}? ");
            result = num1 * num2;
            break;
        case "4":
        result = num1 / num2;
            if (num2 != 0)
        {
             Console.WriteLine($"What is {num1} / {num2}? ");
        }
            
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }
    
}