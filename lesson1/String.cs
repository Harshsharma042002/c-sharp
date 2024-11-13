using System;
using System.Threading;
using System.Text;

public class String
{
    public static void SwitchLesson()
    {
        
        // Usage of double backslash, @ in strings
        string path = "Harsh\\nSharma";
        string path1 = @"harsh" + "\nsharma";
        Console.WriteLine(path);
        Console.WriteLine(path1);

        // String formatting
        string name = "harsh";
        int age = 22;
        Console.WriteLine("Name: " + name + "\nAge: " + age);
        Console.WriteLine("Your name is " + name + ", and your age is " + age);
        Console.WriteLine("Your name is {0}, and your age is {1}", name, age);
        Console.WriteLine("Name: {0}\nAge: {1}", name, age);

        // Concatenation
        string naming = string.Concat("Your name is ", name, " and your age is ", age);
        Console.WriteLine(naming);

        // Empty string check
        Console.Write("What is your name? : ");
        string emptyOne = Console.ReadLine();
        if (emptyOne != string.Empty)
            Console.Write($"Your name is: {emptyOne}");
        else
            Console.Write("Name can't be empty.");

        // Equals function
        Console.Write("Who is the best friend of Harsh? ");
        string frnd = "MADHUSUDHAN";
        string askFrnd = Console.ReadLine();
        if (askFrnd.Equals(frnd))
            Console.Write("Yes, you are damn right!");
        else
            Console.Write("You are wrong, think again!");

        // String looping
        string message = "hi this is harsh";
        for (int i = 0; i < message.Length; i++)
        {
            Console.Write(message[i]);
            Thread.Sleep(250); // Display output by delay of 250ms
        }
        Console.WriteLine(message.Contains("h"));

        // IsNullOrEmpty
        Console.Write("Enter your name: ");
        string askName = Console.ReadLine();
        if (string.IsNullOrEmpty(askName))
            Console.Write("Forgot to write a name.");
        else
            Console.Write(askName);

        // Reverse a string using loop and StringBuilder
        Console.Write("\nEnter a msg: ");
        string orgMsg = Console.ReadLine();

        // Using a for loop to print characters in reverse
        Console.WriteLine("Reversed string using loop (with delay):");
        for (int i = orgMsg.Length - 1; i >= 0; i--)
        {
            Console.Write(orgMsg[i]);
            Thread.Sleep(250); // Display output with a delay of 250ms
        }

        // Newline for better output separation
        Console.WriteLine();

        // Using StringBuilder to reverse the string
        StringBuilder reversed = new StringBuilder();
        for (int i = orgMsg.Length - 1; i >= 0; i--)
        {
            reversed.Append(orgMsg[i]);  // Append characters in reverse order
        }

        Console.WriteLine("Reversed string using StringBuilder: " + reversed.ToString());
        
        Console.Write("enter anything :");
        string pal=Console.ReadLine();
        int n=pal.Length;
        bool isPal=true;
        for (int i = 0; i < n/2; i++)
        {
            if(pal[i]!=pal[n-i-1]) {
                isPal=false;
                break;
            }
        }
        if (isPal) Console.WriteLine(" it's a palindrome");
        else Console.WriteLine(" it's not a palindrome");
        */

        //password checker
        Console.Write("enter a password : ");
        string pass=Console.ReadLine();
        Console.Write("enter your password again : ");
        string passCon=Console.ReadLine();
        if(string.IsNullOrEmpty(pass)) Console.WriteLine("please enter your password bro ");
        else if(string.IsNullOrEmpty(passCon)) Console.WriteLine("please enter your password AGAIN bro ");
        else if(pass.Equals(passCon)) Console.WriteLine("passwords are CORRECT");
        else Console.WriteLine("passwords are INCORRECT");

    }

    
}
