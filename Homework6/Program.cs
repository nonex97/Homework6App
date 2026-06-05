// Create an array of 3 names. Ask the user which number to select.
// When the user gives a number, return that name.
// Make sure to check for invalid numbers.


string[] firstNames = new string[] { "Neven", "Yukica", "John" };
string userChoiceText;
int userChoice;
bool isValidNumber;

do
{
    Console.Write("Enter a number to select a name: ");
    userChoiceText = Console.ReadLine();
    isValidNumber = int.TryParse(userChoiceText, out userChoice);
    if (isValidNumber == false)
    {
        Console.WriteLine("Invalid number! Please enter a valid number.");
    }
    else if (userChoice > firstNames.Length - 1 || userChoice < 0)
    {
        Console.WriteLine("There is no name at this index!");
    }
    else
    {
        Console.WriteLine($"The name is {firstNames[userChoice]}.");
    }
} while (isValidNumber == false);