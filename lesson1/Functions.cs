using System;

public class Functions
{
    /*
    // Function with parameters (adds two integers)
    public static int sumAdd(int a, int b)
    {
        return a + b;
    }

    // Function that multiplies two numbers
    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    // Function that returns an array of integers
    public static int[] GetNumbers()
    {
        return new int[] { 1, 2, 3, 4, 5 };
    }

    // Function that takes an array and displays its contents
    public static void DisplayNumbers(int[] numbers)
    {
        Console.WriteLine("Numbers in the array:");
        foreach (int item in numbers)
        {
            Console.WriteLine($"Number: {item}");
        }
    }

    // Function that checks if a number is even or odd
    public static string CheckEvenOdd(int num)
    {
        return num % 2 == 0 ? "Even" : "Odd";
    }

    // Function that takes multiple parameters and returns the average
    public static double CalculateAverage(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return (double)sum / numbers.Length;
    }

    // Function that demonstrates method overloading (same name, different parameters)
    public static void PrintMessage(string message)
    {
        Console.WriteLine($"Message: {message}");
    }

    public static void PrintMessage(int number)
    {
        Console.WriteLine($"Number: {number}");
    }

    // Function that swaps two numbers (using ref parameters)
    public static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    
    public static int ReadInt(string messages){
        Console.Write(messages);
        return Convert.ToInt32(Console.ReadLine());
    }
    public static int CalculateArea(int width,int height){
        return (width*height)/2;
    }
    */
    public static int[] getArray(){
        Console.WriteLine("enter the number of elements to put in the array : ");
        int size=Convert.ToInt32(Console.ReadLine());
        int[]arr=new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"enter element {i+1} :");
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }
        return arr;
    }
    public static int calculateTotal(int[] arr){
        int total=0;
        foreach (int item in arr)
        {
            total+=item;
        }
        return total;
    }

    // Main function that calls various methods
    public static void FunctionsLesson()
    {
        Console.WriteLine("Hi from functions");
/*
        // Calling the sumAdd method
        int sumOf2 = sumAdd(5, 6);
        Console.WriteLine($"The sum of 2 numbers is: {sumOf2}");

        // Calling the Multiply method
        int product = Multiply(4, 5);
        Console.WriteLine($"The product of 4 and 5 is: {product}");

        // Calling GetNumbers and DisplayNumbers
        int[] fnNum = GetNumbers();
        DisplayNumbers(fnNum);

        // Calling CheckEvenOdd
        Console.WriteLine($"The number 7 is: {CheckEvenOdd(7)}");

        // Calling CalculateAverage
        double avg = CalculateAverage(5, 10, 15, 20);
        Console.WriteLine($"The average is: {avg}");

        // Calling PrintMessage (method overloading)
        PrintMessage("Hello World");
        PrintMessage(123);

        // Swapping numbers using ref parameters
        int a = 10, b = 20;
        Console.WriteLine($"Before Swap: a = {a}, b = {b}");
        Swap(ref a, ref b);
        Console.WriteLine($"After Swap: a = {a}, b = {b}");
        
        //calculate area of triangle
        int width=ReadInt("enter the width ");
        int height=ReadInt("enter the height ");
        int area=CalculateArea(width,height);
        Console.WriteLine($"the area of {width} and {height} is: {area}");
        */
        int[] userArr=getArray();
        int totalSum=calculateTotal(userArr);
        Console.WriteLine($"the sum of elements in the array : {totalSum}");
    }
}
