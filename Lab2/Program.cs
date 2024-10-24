// See https://aka.ms/new-console-template for more information
string userInput;

do
{
    Console.WriteLine("Hello, World!");

    Console.Write("Would you like to continue (y/n)? ");
    userInput = Console.ReadLine().ToLower();

} while (userInput == "y");

Console.WriteLine("Goodbye!");

// part 2

string userResponse;

do
{

    Console.Write("Enter a number ");
    int number = int.Parse(Console.ReadLine());

    // Loop to count down from the number to 0
    for (int i = number; i >= 0; i--)
    {
        Console.Write(i);
    }
    Console.WriteLine(); // New line after the countdown

    // Loop to count up from 0 to the number
    for (int i = 0; i <= number; i++)
    {
        Console.Write(i);
    }
    Console.WriteLine(); // New line after counting up


    Console.Write("Would you like to continue (y/n)? ");
    userResponse = Console.ReadLine().ToLower();

} while (userResponse == "y");

Console.WriteLine("Goodbye!");

// part 3 

string correctCode = "13579";

bool isLocked = true;

while (isLocked)
{
    Console.Write("Enter the key code: ");
    string userCode = Console.ReadLine();


    if (userCode == correctCode)
    {
        isLocked = false;
        Console.WriteLine("Welcome! The door is now unlocked.");
    }
    else
    {
        Console.WriteLine("Incorrect code. Please try again.");
    }
}

// part 3 continued

string correctCodee = "13579";

bool isLockedd = true;

int attempts = 0;

int maxAttempts = 5;

// While the door is locked and attempts are less than the max allowed attempts
while (isLockedd && attempts < maxAttempts)
{
    Console.Write("Enter the key code: ");
    string userCode = Console.ReadLine();
    attempts++; // Increase the attempts

    // Check if the entered code matches the correct code
    if (userCode == correctCodee)
    {
        isLockedd = false;
        Console.WriteLine("Welcome! The door is now unlocked.");
    }
    else if (attempts < maxAttempts)
    {
        Console.WriteLine("Incorrect code. Please try again.");
    }
}

// If the loop ended because the maximum attempts were reached and the door is still locked
if (isLockedd)
{
    Console.WriteLine("Too many incorrect attempts. Access denied.");
}
