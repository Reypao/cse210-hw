using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assigment1 = new Assignment("Efrey Guzman", "Substraction");
        Console.WriteLine(assigment1.GetSummary());

        MathAssignment assigment2 = new MathAssignment("Daniela Juarez", "Functions", "7.3", "8-19");
        Console.WriteLine(assigment2.GetSummary());
        Console.WriteLine(assigment2.GetHomeworkList());

        WritingAssignment assigment3 = new WritingAssignment("Emma Dominguez", "Colombian History", "The Causes of Civil War");
        Console.WriteLine(assigment3.GetSummary());
        Console.WriteLine(assigment3.GetWritingInformation());
    }
}