using System;
public class BasicCalculator
{
    static void showMenu(){
        Console.WriteLine("\n --- calculator menu---");
        Console.WriteLine(" 1. Addition ");
        Console.WriteLine(" 2. Subraction ");
        Console.WriteLine(" 3. Multiplication ");
        Console.WriteLine(" 4. Division ");
        Console.WriteLine(" 5. Square root ");
        Console.WriteLine(" 6. Power 'Exponentiation' ");
        Console.WriteLine(" 7. Modulus ");
        Console.WriteLine(" 8. Trigonmetric Functions 'sin cos tan' ");
        Console.WriteLine(" 9. Factorial ");
        Console.WriteLine(" 10. Exit ");
    }
    static void performBasicOperations(string operationName,Func<double, double, double> operation){
        double num1=GetNumInput($"Enter the first number for {operationName}:");
        double num2=GetNumInput($"Enter the second number for {operationName}:");
        try
        {
            double result=operation(num1,num2);
            Console.WriteLine($"Result is : {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error is : {ex.Message}");
        }
    }
    static void perfromExponention(){
        double baseNumber=GetNumInput("Enter the base number: ");
        double ExponentNumber=GetNumInput("Enter the exponent number: ");
        Console.WriteLine($"Result : {Math.Pow(baseNumber,ExponentNumber)}");
    }
    static void performSquareRoot(){
        double num=GetNumInput("Enter a number to find the square: ");
        if(num<0) Console.WriteLine("Cannot find the square root for negative numbers");
        else Console.WriteLine($"Result : {Math.Sqrt(num)}");
    }
    static void perfromModulus(){
        double num1=GetNumInput("Enter the first number: ");
        double num2=GetNumInput("Enter the divisor: ");
        Console.WriteLine($"Result: {num1 % num2}");
    }
    static void performTrignomtericFunctions(){
        double angle=GetNumInput("Enter the angle in degrees :");
        double radians=DegreeToRadian(angle);
        Console.WriteLine($"sin({angle}) = {Math.Sin(radians)}");
        Console.WriteLine($"cos({angle}) = {Math.Cos(radians)}");
        Console.WriteLine($"tan({angle}) = {Math.Tan(radians)}");
    }
    static void performFactorial(){
        int number=(int)GetNumInput("Enter a non-negative number to find its factorial: ");
        if(number<0) Console.WriteLine("Enter a positive number: ");
        else Console.WriteLine($"Result : {Factorial(number)}");
    }
    static double GetNumInput(string prompt){
        Console.Write(prompt);
        while (true)
        {
            if(double.TryParse(Console.ReadLine(),out double number)) return number;
            else Console.WriteLine("Invalid input ! Enter a valid number");
        }
    }
    static double DegreeToRadian(double angle){
        return Math.PI * angle / 180.0;
    }
    static long Factorial(int n){
        long result=1;
        for (int i = 1; i<=n; i++)
        {
            result*=i;
        }
        return result;
    }
    
    public static void CalculatingProcess(){
        bool continueCalculating=true;
        Console.WriteLine("---welcome to the C# Advanced Calculator---");
        while (continueCalculating)
        {
            showMenu();
            Console.Write(" Select an option from 1-10 :  ");
            string selecetedChoice=Console.ReadLine();
            switch (selecetedChoice)
            {
                case "1":
                    performBasicOperations("Addition" ,(a,b)=>a+b);
                    break;
                case "2":
                    performBasicOperations("Subtraction" ,(a,b)=>a-b);
                    break;
                case "3":
                    performBasicOperations("Multiplication" ,(a,b)=>a*b);
                    break;
                case "4":
                    performBasicOperations("Division" ,(a,b)=>b!=0 ? a/b : throw new DivideByZeroException());
                    break;
                case "5":
                    performSquareRoot();
                    break;
                case "6":
                    perfromExponention();
                    break;
                case "7":
                    perfromModulus();
                    break;
                case "8":
                    performTrignomtericFunctions();
                    break;
                case "9":
                    performFactorial();
                    break;
                case "10":
                    continueCalculating=false;
                    Console.WriteLine("Thank you for using the calculator! GoodBye !");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again");
                    break;
            }  
            Console.WriteLine();
        }
    }
}