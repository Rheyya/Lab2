// See https://aka.ms/new-console-template for more information

string correctCode = "13579";

bool isLocked = true;

int attempts = 0;

int maxAttempts = 5;

// Use a do-while loop to prompt the user for the code
do
{
    Console.Write("Enter the key code: ");
    string userCode = Console.ReadLine();
    attempts++;


    if (userCode == correctCode)
    {
        isLocked = false;
        Console.WriteLine("Welcome! The door is now unlocked.");
    }
    else if (attempts < maxAttempts)
    {
        Console.WriteLine("Incorrect code. Please try again.");
    }

} while (isLocked && attempts < maxAttempts);

// If the loop ended because the maximum attempts were reached and the door is still locked
if (isLocked)
{
    Console.WriteLine("Too many incorrect attempts. Access denied.");
}
