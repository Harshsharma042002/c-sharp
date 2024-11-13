using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("enter your name:");
        string name=Console.ReadLine();
        Console.Write("enter tour age:");
        string age=Console.ReadLine();
        Console.WriteLine("your name is:"+ name+ "  your age is"+age);
        Console.ReadLine();

        //converting string to int in readline
        String ageInput=Console.ReadLine();
        int ageIs=Convert.ToInt32(ageInput);
        Console.WriteLine("the age from readline is : " + ageIs);

        //one more way 
        Console.WriteLine("whats y0ur age:");
        int conAge=Convert.ToInt32(Console.ReadLine());
    
        Conditional.PrintingMessage();
        
        Loops.AllLoops();

        String.SwitchLesson();
    
        Arrays.ArrayLesson();
        
        Lists.ListLesson();
        
        Dictionary.DictionaryLesson();
        
        Functions.FunctionsLesson();
        
        ExceptionHandling.ExceptionHandlingLesson();
        
        Structures.StructuresLesson();
        
        Classes.ClassesLesson();
        Console.ReadLine();
        
        
    }
}
