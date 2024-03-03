using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userGrade = Console.ReadLine();
        int percUser = int.Parse(userGrade);

        string letter = "";
        string sign = ""; // Variable to hold the sign (+, -, or nothing)

        // Determine the letter grade
        if (percUser >= 90)
        {
            letter = "A";
        }
        else if (percUser >= 80)
        {
            letter = "B";
        }
        else if (percUser >= 70)
        {
            letter = "C";
        }
        else if (percUser >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the sign based on the last digit
        int lastDigit = percUser % 10;
        if (percUser >= 60 && percUser < 90) // Exclude A and F grades from having signs
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Special case handling: There is no A+ or F+ and F-
        if (letter == "A" && sign == "+")
        {
            sign = ""; // A+ doesn't exist, revert to A
        }
        else if (letter == "F")
        {
            sign = ""; // F+ and F- don't exist, revert to F
        }

    Console.WriteLine($"Your grade is: {letter}{sign}");

        if (percUser >= 70)
        {
            Console.WriteLine("Congratulations!. You approved!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}