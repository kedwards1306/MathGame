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
}

//creating Choices in switch break cases
// selection 1. - Addition so userInput1 + userInput2
// selection 2. - Subtraction so userInput1 - userInput2
// selection 3. - Multiplication so userInput1 * userInput2
// selection 4. - Division so userInput1 / userInput2
// selection 5. - could be random or more than one formula
//
