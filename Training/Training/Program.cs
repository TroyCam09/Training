using System;
using System.Numerics;

class MyClass
{
    static void Main()
    {
        PrintToConsole();
        VariablesAndDataTypes();
        MathOpertors();
        ComparisonOperators();
    }

    static void PrintToConsole()
    {
        Console.WriteLine("Hello World!");
    }

    static void VariablesAndDataTypes()
    {
        int age = 30;
        Console.WriteLine(age);

        float temp = 20.4f;
        Console.WriteLine(temp);

        double intrest = 5.53;
        Console.WriteLine("Intest: " + intrest);

        decimal stockPrice = 4.535353535353M;
        Console.WriteLine("Stock price" + stockPrice);
        
        char grade = 'A';
        Console.WriteLine("Grade: " + grade);
        
        string firstName = "John";
        Console.WriteLine("First name: " + firstName);

        bool isStudent = true;
        Console.WriteLine("Is student?: " + isStudent);

        int quantity;
        string product;
        
        quantity = 5;
        product = "Bananas";
        Console.WriteLine($"Product: {product}, quantity {quantity}");
        
        const double Pi = 3.14;
        Console.WriteLine(Pi);
    }

    static void MathOpertors()
    {
        int num1 = 10;
        int num2 = 5;
        
        int add = num1 + num2;
        Console.WriteLine("Add:" + add);
        
        int sub = num1 - num2;
        Console.WriteLine("Subtract :" + sub);
        
        int mul = num1 * num2;
        Console.WriteLine("Multiply :" + mul);
        
        int div = num1 / num2;  
        Console.WriteLine("Divide :" + div);
        
        int mod = 11 % 5;
        Console.WriteLine("Modulus" + mod);

        int num3 = 5;
        int num4 = 0;

        try
        {
            int quotient = num3 / num4;
            Console.WriteLine("Quotient: " + quotient);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("An error occurred " + ex.Message);
        }

        int num5 = 105;
        double num5AsDouble = (double)num5; 
        Console.WriteLine(num5AsDouble);
    }

    static void ComparisonOperators()
    {
        int a = 10;
        int b = 5;
        
        bool isEqual = a == b;
        Console.WriteLine(isEqual);
        
        bool notEqual = a != b;
        Console.WriteLine(notEqual);
    }
}