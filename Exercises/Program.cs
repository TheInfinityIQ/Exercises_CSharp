using System;
using System.Collections.Generic;

/*
=============================================================================================
				C# Exercises (Finally!!!)
=============================================================================================
ATTENTION: To make it more challenging make sure your programs only accept the correct input.
=============================================================================================
Before we begin, here are some useful links:
- Data Types: https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/types-and-variables
- Statements: https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/statements
- Loops: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/iteration-statements
=============================================================================================

1 - Write a C# console app that accepts five letters (strings) and display them in reverse order.
Sample first input: a 
Sample second input: b 
Sample third input: c
Sample fourth input: d
Sample fifth input: e
Expected output: e, d, c, b, a
*BONUS: Make sure your program doesn't accept numbers! Don't know how to check if the input is a number? http://bfy.tw/MCGn

===========================================

2 - Write a C# console app that accepts five numbers and calculate the average.
Sample first input: 1
Sample second input: 2
Sample third input: 3
Sample fourth input: 4
Sample fifth input: 5
Expected output: 3

===========================================

3 - Write a C# console app that accepts two numbers, a mathematical operator (+,-,*,/) and displays the result to the user. 
Sample first input: 1
Sample input operation: +
Sample second input: 2
Expected output: 3
*BONUS: Make the program menu driven for the operation.
Sample first input: 1
Sample second input: 2
Choose one of the following operations:
1-Addition. 
2-Subtraction. 
3-Multiplication. 
4-Division.
Sample input for operation: 1
Expected output: 3

===========================================

4 - Write a C# console app that accepts a number and print its multiplication table.
Sample input: 2
Expected output:
2x1=2
2x2=4
2x3=6
...
2x10
...

===========================================

5 - Write a C# console app that accepts a character and check if it is a vowel, a digit, or any other character.
To make it easier try converting the character to lowercase before doing the checks.
Sample input: a
Expected output: It's a vowel.
Sample input: 5
Expected output: It's a digit.
Sample input: t
Expected output: it's another character.

-----------------------------------------------------------------------------------------------------------------------------------------------------

=============================================================================================
				C# Exercises - Part Two
=============================================================================================
ATTENTION: To make it more challenging make sure your programs only accept the correct input.
=============================================================================================
Some other useful links:
- Lists: https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netframework-4.7.2
- Arrays: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/
- Discussion Arrays vs Lists: https://stackoverflow.com/questions/434761/array-versus-listt-when-to-use-which
=============================================================================================

6 - Write a C# console application that accepts a letter or number and a width (number) and displays a triangle of that width, using that character.
Sample input: A 
Sample input width: 5 
Expected output:
AAAAA
AAAA
AAA
AA
A
*BONUS: Display the triangle in reverse order
Expected output:
A
AA
AAA
AAAA
AAAAA

===========================================

7 - Write a C# console app that accepts a grade from a student and show the description according to the table below:
Grade	Description
A		Excelent
B		Good
C		Average
D		Fail
Sample input: C
Expected output: Average

===========================================

8 - Write a C# console app that given the array below, removes all duplicated items and returns a new array in the same sequential order as the old array (minus duplicates).
Sample array: ["Student", "Developer" "Great", "Developer"]
Expected output: ["Student", "Great", "Developer"]

===========================================

9 - Write a C# console app that accepts a string and returns the numbers (count) of vowels contained within it.
Sample input: Internship
Expected output: 3

===========================================


10 - Write a C# console app that accepts a username and password. If the user enters the username/password correctly display a success message. If the user enters the username/password incorrectly display an error message. After 3 invalid attemps stop the user from trying and display a final error message.
Sample input username: user1
Sample input password: password1
Expected output if correct: Password entered sucessfully!
Expected output if incorrect: Username and/or password are incorrect.
Expected output after 3 incorrect attemps: You've entered the username and/or password incorrect 3 times. Try again later.
*Bonus: Display a hint to the user after the first incorrect attempt.

-----------------------------------------------------------------------------------------------------------------------------------------------------

=============================================================================================
				C# Exercises - Homework
=============================================================================================
ATTENTION: To make it more challenging make sure your programs only accept the correct input.
=============================================================================================

1 - Write a C# console app that accepts a string and Capitalize the First Letter Of Each Word.
Sample input: This is an example
Expected output: This Is An Example

===========================================

2 - Write a C# console app that accepts two dates in the YYYY-MM-DD format and display the names of the months that are present between them.
Sample first input: 2019-01-01
Sample second input: 2019-03-01
Expected output: January, February, March

===========================================

3 - Write a C# console app that accepts a number and then display the result of adding up all the numbers from 1 to the number that was given as input. 
Sample input: 5
Expected output: 15 (1+2+3+4+5)

===========================================

4 - Write a C# console app that accepts a string and returns the word count.
Sample input: This is just an example.
Expected ouput: 5

===========================================

5 - Given the array below, write a C# console app that displays:
Sample array: ["a", "5", "t", "99", "z", "true"]
a - Last item: true
b - Largest number: 99
c - Smallest number: 5
d - First item: a

----------------------------------------------------------------------------------------------------------------------------------------------------- 
*/

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Write a C# console app that accepts five letters (strings) and display them in reverse order.
            //Sample first input: a
            //Sample second input: b
            //Sample third input: c
            //Sample fourth input: d
            //Sample fifth input: e
            //Expected output: e, d, c, b, a
            //* BONUS: Make sure your program doesn't accept numbers! Don't know how to check if the input is a number ? http ://bfy.tw/MCGn

            /*string[] characters = new string[5];

            for (int i = 0; i < characters.Length; i++)
            {
                Console.WriteLine("Enter a character");
                string letter = Console.ReadLine();

                characters[i] = letter;
            }

            for (int i = characters.Length-1; i >= 0; i--)
            {
                if (i >= 1)
                {
                    Console.Write(characters[i] + ", ");
                }
                else
                {
                    Console.Write(characters[i]);
                }
            }
            Console.ReadLine();*/

            //2 - Write a C# console app that accepts five numbers and calculate the average.
            //Sample first input: 1
            //Sample second input: 2
            //Sample third input: 3
            //Sample fourth input: 4
            //Sample fifth input: 5
            //Expected output: 3

            //int[] numbers = new int[5];
            //int toBeAveraged = 0;

            //for (int i = 0; i <= numbers.Length-1; i++)
            //{
            //    Console.WriteLine("Enter a number, lil' boy: ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i <= numbers.Length-1; i++)
            //{
            //    toBeAveraged += numbers[i];
            //}

            //Console.WriteLine(toBeAveraged / numbers.Length);
            //Console.ReadLine(); //Please stop closing

            //3 - Write a C# console app that accepts two numbers, a mathematical operator (+,-,*,/) and displays the result to the user. 
            //Sample first input: 1
            //Sample input operation: +
            //Sample second input: 2
            //Expected output: 3
            //* BONUS: Make the program menu driven for the operation.
            //Sample first input: 1
            // Sample second input: 2
            // Choose one of the following operations:
            //1 - Addition.
            // 2 - Subtraction.
            // 3 - Multiplication.
            // 4 - Division.
            // Sample input for operation: 1
            // Expected output: 3

            //    string lineSpam = new string('-', 10);

            //    Console.WriteLine(lineSpam + "\nHere's my menu for bonus marks" + lineSpam + "\n\n");

            //    Console.WriteLine("Enter number one: ");
            //    int numberOne = int.Parse(Console.ReadLine());

            //    Console.WriteLine(lineSpam + "\nEnter which operator you'd like to use from the list below\n" + lineSpam +
            //        "\n\n1 - Addition." +
            //        "\n2 - Subtraction." +
            //        "\n3 - Multiplication." +
            //        "\n4 - Division.");
            //    string answer = Console.ReadLine();

            //    Console.WriteLine("Enter number two: ");
            //    int numberTwo = int.Parse(Console.ReadLine());

            //    if (int.TryParse(answer, out _))
            //    {
            //        Calculation(numberOne, numberTwo, operationInt: int.Parse(answer));
            //    }
            //    else if (char.TryParse(answer, out _))
            //    {
            //        Calculation(numberOne, numberTwo, operationChar: char.Parse(answer));
            //    }
            //    else
            //    {
            //        Console.WriteLine("Literally not what I asked for, retard.");
            //    }
            //}

            //static void Calculation(int numberOne, int numberTwo, int operationInt = -1, char operationChar = '.') {

            //    (int inputInt, char inputChar) tuple = (operationInt, operationChar);

            //    switch (tuple)
            //    {
            //        case (_, '+'):
            //        case (1, _):
            //            Console.WriteLine(numberOne + numberTwo);
            //            break;
            //        case (_, '-'):
            //        case (2, _):
            //            Console.WriteLine(numberOne - numberTwo);
            //            break;
            //        case (_, '*'):
            //        case (3, _):
            //            Console.WriteLine(numberOne * numberTwo);
            //            break;
            //        case (_, '/'):
            //        case (4, _):
            //            Console.WriteLine(numberOne / numberTwo);
            //            break;
            //        default:
            //            Console.WriteLine("How? Literally how. ");
            //            break;
            //    }
            //}

            //4 - Write a C# console app that accepts a number and print its multiplication table.
            //Sample input: 2
            //Expected output:
            //2x1 = 2
            //2x2 = 4
            //2x3 = 6...
            //2x10...

            //Console.WriteLine("Enter how many multiplications you would like: ");
            //int numberOfMultiples = int.Parse(Console.ReadLine());

            //Console.WriteLine("What is the number you'd like multiples of: ");
            //int numberToMultiply = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //for (int i = 1; i <= numberOfMultiples; i++)
            //{
            //    Console.WriteLine(numberToMultiply + "x" + i + " = " + numberToMultiply * i);
            //}

            //5 - Write a C# console app that accepts a character and check if it is a vowel, a digit, or any other character.
            //To make it easier try converting the character to lowercase before doing the checks.
            //Sample input: a
            //Expected output: It's a vowel.
            //Sample input: 5
            //Expected output: It's a digit.
            //Sample input: t
            //Expected output: it's another character.

            //    Console.WriteLine("Enter a digit, a letter, or a vowel: ");
            //    string inputFromUser = Console.ReadKey().KeyChar.ToString().ToLower();
            //    Console.WriteLine();

            //    if (IsDigit(inputFromUser))
            //    {
            //        Console.WriteLine("It's a digit.");
            //    }
            //    else if (IsVowel(inputFromUser))
            //    {
            //        Console.WriteLine("It's a vowel.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("it's another character.");
            //    }


            //static bool IsDigit(string inputFromUser)
            //{
            //    if (int.TryParse(inputFromUser, out _))
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}

            //static bool IsVowel(string inputFromUser)
            //{
            //    char[] charArray = {'a', 'e', 'i', 'o', 'u', 'y'};


            //    for (int i = 0; i < charArray.Length; i++)
            //    {
            //        if (inputFromUser[0] == charArray[i])
            //        {
            //            return true;
            //        }
            //        else
            //        {
            //            return false;
            //        }
            //    }

            //    if (int.TryParse(inputFromUser, out _))
            //    {
            //        return true; //Returning 0 because it's a digit
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}

            //=============================================================================================
            //    C# Exercises - Part Two
            //=============================================================================================
            //ATTENTION: To make it more challenging make sure your programs only accept the correct input.
            //=============================================================================================
            //Some other useful links:
            //- Lists: https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netframework-4.7.2
            //- Arrays: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/
            //- Discussion Arrays vs Lists: https://stackoverflow.com/questions/434761/array-versus-listt-when-to-use-which
            //=============================================================================================

            //6 - Write a C# console application that accepts a letter or number and a width (number) and displays a triangle of that width, using that character.
            //Sample input: A 
            //Sample input width: 5 
            //Expected output:
            //AAAAA
            //AAAA
            //AAA
            //AA
            //A
            //*BONUS: Display the triangle in reverse order
            //Expected output:
            //A
            //AA
            //AAA
            //AAAA
            //AAAAA


            //Console.WriteLine("Enter a letter: ");
            //char charFromUser = Console.ReadKey().KeyChar;
            //Console.WriteLine();

            //int maxWidth;

            //Console.WriteLine("Enter a digit: ");
            //while (!int.TryParse(Console.ReadLine(), out maxWidth))
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("ENTER A DIGIT: ");
            //}

            //Console.ResetColor();
            //Console.WriteLine();

            //for (int i = maxWidth; i > 0; i--) //Prints descending rows
            //{
            //    Console.WriteLine(new string(charFromUser, i));
            //}
            //for (int i = 0; i <= maxWidth; i++) //Prints ascending rows
            //{
            //    Console.WriteLine(new string(charFromUser, i));
            //}

            //7 - Write a C# console app that accepts a grade from a student and show the description according to the table below:
            //Grade Description
            //A Excellent
            //B Good
            //C Average
            //D Fail
            //Sample input: C
            //Expected output: Average

            Dictionary<char, string> grades = new Dictionary<char, string>()
            {
                ['A'] = "Excellent",
                ['B'] = "Good",
                ['C'] = "Average",
                ['D'] = "Fail",
            };

            string gradeDescription;


            foreach (KeyValuePair<char, string> entry in grades)
            {
                Console.WriteLine($"{ entry.Key } { entry.Value }");
            }
            Console.WriteLine("Enter a character grade value: ");

            while (!grades.TryGetValue(char.ToUpper(Console.ReadKey().KeyChar), out gradeDescription))
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                foreach (KeyValuePair<char, string> entry in grades)
                {
                    Console.WriteLine($"{ entry.Key } { entry.Value }");
                }
            }

            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(gradeDescription);

            //8 - Write a C# console app that given the array below, removes all duplicated items and returns a new array in the same sequential order as the old array (minus duplicates).
            //Sample array: ["Student", "Developer" "Great", "Developer"]
            //Expected output: ["Student", "Great", "Developer"]


        }
    }
}
