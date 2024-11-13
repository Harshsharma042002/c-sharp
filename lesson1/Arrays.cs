using System;

public class Arrays{
    public static void ArrayLesson(){
        
        int[] nums = new int[3];
        Console.Write("Enter number 1: ");
        nums[0] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number 2: ");
        nums[1] = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine($"Number 1: {nums[0]}, Number 2: {nums[1]}");

        //using for loop
        for (int i = 0; i <nums.Length; i++)
        {
            Console.Write($"Numbers:{nums[i]} ");
        }
        

        //forEach
        int[] numForEach=new int[5];
        for (int i = 0; i < numForEach.Length; i++)
        {
            Console.Write("write number :");
            numForEach[i]=Convert.ToInt32(Console.ReadLine());
        }
        foreach (int num in numForEach)
        {
            Console.Write($"Number : {num} ");
        }
        

        //triangle
        const int angleCnt=3;
        int[] angles=new int[3];
        for (int i = 0; i < angles.Length; i++)
        {
            Console.Write($"enter angle{i + 1} : ");
            angles[i]=Convert.ToInt32(Console.ReadLine());
        }
        int angleSum=0;
        foreach (int Angles in angles)
        {
            angleSum += Angles;
        }
        Console.WriteLine("the sum of angles are :"+angleSum);
        Console.WriteLine(angleSum==180?"Valid":"InValid");

        //sorting
        int[] numbers=new int[] {4,23,43,12,45,464,1231325};
        Array.Sort(numbers);
        foreach (int sorted in numbers)
        {
            Console.Write($"{sorted} ");
        }
        
        //reverse a array
        int[] arrayRev=new int[] {1,2,3,4,5};
        int n=arrayRev.Length;
        for (int i = 0; i < n/2; i++)
        {
            int temp=arrayRev[i];
            arrayRev[i]=arrayRev[n-i-1];
            arrayRev[n-i-1]=temp;
        }
        Console.Write("reveresed array is "+ string.Join(", ",arrayRev));
        

        //clearing the array
        int[] clearArr=new int[] {1,2,3,4,5,6,7,8,9,10};
        Array.Clear(clearArr,5,5); //1st 5-starting 2nd one indicates the next 5
        foreach (int cleared in clearArr)
        {
            Console.Write($"{cleared}");
        }
        

        //indexof in array
        int[] indexArr=new int[] {22,33,44,55,66,77,88,99};
        Console.Write("enter a number whose index u want 2 know : ");
        int search=Convert.ToInt32(Console.ReadLine());
        int pos=Array.IndexOf(indexArr,search);
        if(pos < 0) Console.WriteLine($"the number {search} is not available in the array");
        else Console.WriteLine($"the position of number {search} has been found at position {pos+1}");
    }
}