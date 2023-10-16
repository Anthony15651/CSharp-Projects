// Challenge 1

// string? readResult;
// int userInput = 0;
// bool validNumber;
// bool validEntry = false;

// Console.WriteLine("Please enter an integer value between 5 and 10.");

// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null)
//     {
//         validNumber = int.TryParse(readResult, out userInput);
//         if ((userInput >= 5) && (userInput <= 10))
//         {
//             validEntry = true;
//             Console.WriteLine($"Your input value ({readResult}) has been accepted.");
//         }
//         else
//         {
//             Console.WriteLine("Your input is invalid, please try again.");
//         }
//     }
// } while (!validEntry);


// Challenge 2

// string? userInput;
// bool validInput = false;

// Console.WriteLine("Please choose from one of the following roles:\nAdministrator\nManager\nUser");

// do
// {
//     userInput = Console.ReadLine().Trim().ToLower();
//     if (userInput != null)
//     {
//         if ((userInput == "administrator") || (userInput == "manager") || (userInput == "user"))
//             validInput = true;
//         else
//             Console.WriteLine($"The name you entered ({userInput}) is not valid. Please try again.");
//     }
// } while (!validInput);

// if (validInput)
//     Console.WriteLine($"Your input ({userInput}) has been accepted.");


// Challenge 3

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringCount = myStrings.Length;

int periodLocation = 0;
string myString = "";

for (int i = 0; i < stringCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    while (periodLocation != -1)
    {
        // The first sentence is the string value to the left of the first period
        mySentence = myString.Remove(periodLocation);

        // The remainder of myString is the string value to the right of the period
        myString = myString.Substring(periodLocation + 1);

        // Removes any leading white space from myString
        myString = myString.TrimStart();

        // Updates the comma location and icrements the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }

    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}




