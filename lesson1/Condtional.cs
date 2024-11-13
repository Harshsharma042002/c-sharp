using System;

public class Conditional
{
    public static void PrintingMessage()
    {
        
        Console.WriteLine("enter your age:");
        string ageIs=Console.ReadLine();
        int age=Convert.ToInt32(ageIs);
        if (age<18)
        {
            Console.WriteLine("your age is "+ age + " and you are a teenager");
        }
        else if(age==18){
            Console.WriteLine("your age is "+ age + " and you are a going to be adult");
        }
        else
        {
             Console.WriteLine("your age is "+ age + " and you are a adult");         
        } 
        
        //one more method
        Console.Write("Enter 1st number:");
        int num1=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter 2nd number:");
        int num2=Convert.ToInt32(Console.ReadLine());
        if(num1 < num2) Console.Write("num1 is smaller than num2 " + num1 + "<" + num2);
        else Console.Write("num2 is smaller than num1 " + num2 + "<" + num1);
        
         
        //switch case:

        Console.WriteLine("enter a day of the week:");
        int day=Convert.ToInt32(Console.ReadLine());
        switch (day)
        {
            case 1:Console.Write("it's monday");
            break;
            case 2:Console.Write("it's tuesday");
            break;
            case 3:Console.Write("it's wednesday");
            break;
            case 4:Console.Write("it's thursday");
            break;
            case 5:Console.Write("it's friday");
            break;
            case 6:Console.Write("it's saturday");
            break;
            case 7:Console.Write("it's sunday bro");
            break;
            default: Console.Write("wrong");
            break;
        }
        Console.Write("enter your age :");
        int ageRightNow=Convert.ToInt32(Console.ReadLine());
        string res=ageRightNow<=18? "not eligible" : "eligible";
        Console.Write(res);

    }
}
