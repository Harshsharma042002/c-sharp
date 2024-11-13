using System;
public class ExceptionHandling{
    public static void ExceptionHandlingLesson(){
        Console.WriteLine("hi from exception");
        /*
        //try-catch
        bool looping=true;
        while (looping)
        {
            try
        {
            Console.WriteLine("enter a number");
            int num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"the number which u typed is : {num}");
            looping=false;
        }
        catch(FormatException e){
            Console.WriteLine($"error : {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"error : {e.Message}");
            
        }    
        }
        System.Console.WriteLine("goodbye");

        //another one
        bool success=false;
        try
        {
            Console.WriteLine("enter a number");
            int numbering=Convert.ToInt32(Console.ReadLine());
            success=true;
        }
        catch (FormatException e)
        {
            Console.WriteLine($"the error is : {e.Message}");
        }
        Console.WriteLine(success ? "yes" : "no");
        */
        Console.WriteLine("Enter a number:");
        if (TryParse(Console.ReadLine(), out int result))
        {
            Console.WriteLine("Correct! You entered: " + result);
        }
        else
        {
            Console.WriteLine("Wrong input! Please enter a valid number.");
        }
    }
    static bool TryParse(string input, out int result)
    {
        try
        {
            result = Convert.ToInt32(input);
            return true;
        }
        catch (Exception)
        {
            result = -1;
            return false;
        }
    }
}