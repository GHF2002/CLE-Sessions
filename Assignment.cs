/*name: Asmita Raosaheb Hon
College : Sanjivani College of Engineering Kopargaon
Domain: App Mod*/


//Assignment No:01


//Q1. Parse the string variables from below into the correct datatypes:

/*public static void Main(string[] args)
{
    string stringForFloat = "0.85";
    float floatVariable = float.Parse(stringForFloat); 

    string stringForInt = "12345";
    int intVariable = int.Parse(stringForInt); 

    Console.WriteLine($"Parsed float: {floatVariable}");
    Console.WriteLine($"Parsed int: {intVariable}");
}*/


//Q2. Declare a string variable and don’t assign any value to it. Print on the console “Please enter your name and press enter”. You can then enter your name or any other valid string like “John”. Assign that entered string to the string variable which you have declared initially. The program should write on the console that string in Uppercase in the first line, then the same string in Lowercase in the second line. In the third line, it writes on the console the string with no trailing or preceding white space like if string entered as “ John Cena ” it should be written on the console as “JohnCena”. And in the last line, it should write the Substring of the entered string on the console.
/*using System;
class Program
{
    static void Main()
    {
        string userInput;
        
        Console.WriteLine("Please enter your name and press enter:");
        userInput = Console.ReadLine();
        string upperCase = userInput.ToUpper();
        Console.WriteLine("Uppercase: " + upperCase);
        string lowerCase = userInput.ToLower();
        Console.WriteLine("Lowercase: " + lowerCase);
        string trimmed = userInput.Trim();
        Console.WriteLine("Trimmed: " + trimmed);
        string substring = userInput.Substring(0, Math.Min(userInput.Length, 5));
        Console.WriteLine("Substring (first 5 characters): " + substring);
    }
}*/

//Q3. Let’s create another console application for more practice.This application asks the user to input a string in the first line like “Enter a string here: ”.In the Second Line, it should ask for the character to search in the string which you have entered in the first line like “Enter the character to search: ”On the third line, it should write the index of the first occurrence of the searched character from the string.Now on concatenation...It should then ask to enter the first name and once the name is written and the enter button is pressed, it should ask to enter the last name.It should then show your full name printed in a single line like in my case the output will be "Denis Panjuta". Output can be different in your case. Try to store the full name in a variable, before displaying it.
/*using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a string here: ");
        string inputString = Console.ReadLine();
        Console.Write("Enter the character to search: ");
        char searchChar = Console.ReadLine()[0];
        int indexOfChar = inputString.IndexOf(searchChar);
        Console.WriteLine($"Index of '{searchChar}' in the string: {indexOfChar}");
        Console.Write("Enter your first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter your last name: ");
        string lastName = Console.ReadLine();
        string fullName = firstName + " " + lastName;
        Console.WriteLine($"Full Name: {fullName}");
    }
}*/


//Q4. Create a variable for each of the primitive datatypes. Leave the Object datatype out. And also please initialize each variable with a working value. Then create two values of type string. The first one should say "I control text"
/*using System;
class Program
{
    static void Main()
    {
        int intValue = 42; 
        double doubleValue = 3.14159; 
        bool boolValue = true; 
        char charValue = 'A'; 
        byte byteValue = 127; 
        short shortValue = 32000; 
        long longValue = 1234567890L; 
        float floatValue = 1.23f; 
        decimal decimalValue = 123.456m; 

        string firstString = "I control text";
        string secondString = "Hello, world!";

        Console.WriteLine($"int: {intValue}");
        Console.WriteLine($"double: {doubleValue}");
        Console.WriteLine($"bool: {boolValue}");
        Console.WriteLine($"char: {charValue}");
        Console.WriteLine($"byte: {byteValue}");
        Console.WriteLine($"short: {shortValue}");
        Console.WriteLine($"long: {longValue}");
        Console.WriteLine($"float: {floatValue}");
        Console.WriteLine($"decimal: {decimalValue}");
        Console.WriteLine($"string 1: {firstString}");
        Console.WriteLine($"string 2: {secondString}");
    }
}*/

//Q5. create three variables with names of your friends. Then create a Method "GreetFriend" which writes something like: "Hi Frank, my friend!" onto the console, once it is called. Where "Frank" should be replaced with the Name behind the argument given to the Method when it's called. So the method will need a parameter (decide which DataType will be best). Greet all your three friends.
/*using System;
class Program
{
    static void Main()
    {
        string friend1 = "Ashwini";
        string friend2 = "Akanksha";
        string friend3 = "Kalyani";

        GreetFriend(friend1);
        GreetFriend(friend2);
        GreetFriend(friend3);
    }

    static void GreetFriend(string friendName)
    {
        Console.WriteLine($"Hi {friendName}, my friend!");
    }
}*/

//Q6. Write two new methods:LowUpper method will take a string as input, create lower- and uppercase copies, and return the result of their join.Example:"lol" string will produse "lolLOL".The Count method also will take a string, but it will not return. It only will print "The amount of characters is X." with X replaced with the actual amount of characters in the string on another line.Example:"lol" string will print "The amount of characters is 3.".Alert!  Both of them should be static and public. So add "static" and "public" keywords like those written below for the Run method.The result of execution for the default string should be:hey there !HEY THERE !The amount of characters is 22.
/*using System;
class Program
{
    static void Main()
    {
        string inputString = "lol";
        string inputString1 = "hey there !";
        string result = LowUpper(inputString, inputString1);
        Console.WriteLine(result);
        Count(inputString, inputString1);
    }

    static string LowUpper(string input1, string input2)
    {
        string lowerCase1 = input1.ToLower();
        string upperCase1 = input1.ToUpper();
        string lowerCase2 = input2.ToLower();
        string upperCase2 = input2.ToUpper();
        return input1 + upperCase1 + " " + input2 + upperCase2;
    }

    static void Count(string input1, string input2)
    {
        int charCount1 = input1.Length;
        int charCount2 = input2.Length;
        Console.WriteLine($"The amount of characters in string 1 is {charCount1}.");
        Console.WriteLine($"The amount of characters in string 2 is {charCount2}.");
    }
}*/

//Q7. Implement method Check that will take an int as an argument and check if it is an odd number or even. Depending on the testing result, it should print a message on the new line "Odd" or "Even" respectively.
/*using System;
class Program
{
    static void Main()
    {
        int numberToCheck = 19; // Change this to any integer you want to check
        Check(numberToCheck);
    }
    static void Check(int number)
    {
        if (number % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
    }
}*/

//Q8. This time you have to complete the NestedCheck method. It is supposed to print the right message in the terminal depending on the given value:-when the value is divisible by 3. You have to print "Divisible by 3.";-when it is not divisible by 3, but divisible by 7 print "Divisible by 7."- Otherwise:-when it is an odd number, print "Odd number."- if not, print "Even number."

//Example:the number is equal to 3, "Divisible by 3." is printed;the number is equal to 28, "Divisible by 7." is printed;the number is equal to 1, "Odd number." is printed;In the attachment, you can find the file OurSolution.txt. Before opening it, try to solve the exercise yourself.
/*using System;
class Program
{
    static void Main()
    {
        int number1 = 3;
        int number2 = 28;
        int number3 = 1;

        NestedCheck(number1);
        NestedCheck(number2);
        NestedCheck(number3);
    }

    static void NestedCheck(int number)
    {
        if (number%3 == 0)
        {
            Console.WriteLine("Divisible by 3.");
        }
        else if (number%7 == 0)
        {
            Console.WriteLine("Divisible by 7.");
        }
        else
        {
            if (number%2 == 0)
            {
                Console.WriteLine("Even number.");
            }
            else
            {
                Console.WriteLine("Odd number.");
            }
        }
    }
}*/

//Q9. Create a user Login System, where the user can first register and then Login in. The Program should check if the user has entered the correct username and password, wenn login in (so the same ones that he used when registering).As we haven't covered storing data yet, just create the program in a way, that registering and logging in, happen in the same execution of it.

/*using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the User Login System!");

        // Registration
        Console.Write("Enter a username: ");
        string username = Console.ReadLine();
        Console.Write("Enter a password: ");
        string password = Console.ReadLine();

        Console.WriteLine("Registration successful!\n");

        // Login
        Console.Write("Enter your username: ");
        string enteredUsername = Console.ReadLine();
        Console.Write("Enter your password: ");
        string enteredPassword = Console.ReadLine();

        if (enteredUsername == username && enteredPassword == password)
        {
            Console.WriteLine("\nLogin successful! Welcome, " + username);
        }
        else
        {
            Console.WriteLine("\nLogin failed. Incorrect username or password.");
        }
    }
}*/

//Q10. Create a user Login System, where the user can first register and then Login in. The Program should check if the user has entered the correct username and password, wenn login in (so the same ones that he used when registering).As we haven't covered storing data yet, just create the program in a way, that registering and logging in, happen in the same execution of it.


//Q11. Create an application with a score, highscore and a highscorePlayer.Create a method which has two parameters, one for the score and one for the playerName.
//When ever that method is called, it should be checked if the score of the player is higher than the highscore, if so, "New highscore is + " score" and in another line "New highscore holder is " + playerName - should be written onto the console, if not "The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer.Consider which variables are required globally and which ones locally.

/*using System;
class Program
{
    // Global variables to store highscore and highscorePlayer
    static int highscore = 0;
    static string highscorePlayer = "";

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Highscore Tracker!");

        // Example calls to the method
        UpdateHighscore(100, "Player1");
        UpdateHighscore(150, "Player2");
        UpdateHighscore(80, "Player3");
    }

    // Method to update highscore and highscorePlayer
    static void UpdateHighscore(int score, string playerName)
    {
        if (score > highscore)
        {
            // Update highscore and highscorePlayer
            highscore = score;
            highscorePlayer = playerName;

            // Display the new highscore information
            Console.WriteLine("New highscore is " + score);
            Console.WriteLine("New highscore holder is " + playerName);
        }
        else
        {
            // Display the old highscore information
            Console.WriteLine("The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer);
        }
    }
}*/


//Q12.Let's create a small application that takes a temperature value as input and checks if the input is an integer or not.If the input value is not an integer value, it should print to the console "Not a valid Temperature". And if the input value is the valid integer then it should work as mentioned below.
//If input temperature value is <=15 it should write "it is too cold here" to the console.
//If input temperature value is >= 16 and is <=28 it should write "it is ok" to the console.
//If the input temperature value is > 28 it should write "it is hot here" to the console.
//Make sure to use ternary operators and not if statements to check for the three conditions, however you can use if statement for the other conditions like to check if the entered value is a valid integer or not.

/*using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a temperature: ");

        // Read the input as a string
        string input = Console.ReadLine();

        // Try to parse the input as an integer
        bool isValidTemperature = int.TryParse(input, out int temperature);

        // Check if it's a valid integer and within the specified range
        string result = isValidTemperature
            ? temperature <= 15 ? "It is too cold here"
            : temperature >= 16 && temperature <= 28 ? "It is ok"
            : "It is hot here"
            : "Not a valid Temperature";

        Console.WriteLine(result);
    }
}*/

//Q13. There are two methods you have to create (one is ForLoop and the other is WhileLoop):
//In the ForLoop method you have to  print on a new line each value from -3 to 3 included using the for loop;
//In the WhileLoop method you need to print values from 3 to - 3 using the while loop.

/*using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Values from -3 to 3 using a For Loop:");
        ForLoop();

        Console.WriteLine("\nValues from 3 to -3 using a While Loop:");
        WhileLoop();
    }

    static void ForLoop()
    {
        for (int i = -3; i <= 3; i++)
        {
            Console.WriteLine(i);
        }
    }

    static void WhileLoop()
    {
        int value = 3;
        while (value >= -3)
        {
            Console.WriteLine(value);
            value--;
        }
    }
}*/

//Q15. Imagine you are a developer and get a job in which you need to create a program for a teacher. He needs a program written in c# that calculates the average score of his students. So he wants to be able to enter each score individually and then get the final average score once he enters -1.
//So the tool should check if the entry is a number and should add that to the sum. Finally once he is done entering scores, the program should write onto the console what the average score is.
//The numbers entered should only be between 0 and 20. Make sure the program doesn't crash if the teacher enters an incorrect value.
//Test your program thoroughly.

/*using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Average Score Calculator");
        Console.WriteLine("Enter student scores between 0 and 20. Enter -1 to calculate the average.");

        int sum = 0;
        int count = 0;

        while (true)
        {
            Console.Write("Enter a score (0-20): ");
            string input = Console.ReadLine();

            if (input == "-1")
            {
                if (count == 0)
                {
                    Console.WriteLine("No scores entered. Average cannot be calculated.");
                }
                else
                {
                    double average = (double)sum / count;
                    Console.WriteLine($"Average Score: {average:F2}");
                }
                break;
            }

            if (int.TryParse(input, out int score))
            {
                if (score >= 0 && score <= 20)
                {
                    sum += score;
                    count++;
                }
                else
                {
                    Console.WriteLine("Score must be between 0 and 20.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 20.");
            }
        }
    }
}*/





