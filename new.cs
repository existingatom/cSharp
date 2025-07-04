using System;
using static System.Console;
using static System.Int32;

class Program
{
    static void Main()
    {
        Write("Enter a number: ");
        string input1 = ReadLine();

        int number1 = Parse(input1);
        
        Write("Enter a number: ");
        string input2 = ReadLine();

        int number2 = Parse(input2); 
        
        if(number1>number2)
        {
            Write($"{number1} is greater");
        }
        else if(number2>number1)
        {
            Write($"{number2} is greater");
        }
        else
        {
            Write("same");
        }
    }
}

