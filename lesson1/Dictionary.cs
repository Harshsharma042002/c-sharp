using System;
using System.Collections.Generic;
public class Dictionary{
    public static void DictionaryLesson(){

        Console.WriteLine("hi from dictionary");
/*
        Dictionary<int,string>names=new Dictionary<int,string>{
            {1,"harsh"},{2,"gokul"},{3,"madhu"}
        };
        foreach (KeyValuePair<int, string> pair in names)
       {
            Console.WriteLine($" key: {pair.Key} - value: {pair.Value}");
       }
        //for loop
        for (int i = 0; i < names.Count; i++)
        {
            KeyValuePair<int, string>pairing=names.ElementAt(i);
            Console.WriteLine($"{pairing.Key} - {pairing.Value}");
        }

        //checking elements
        Console.WriteLine("enter a key to find ");
        int checkKey=Convert.ToInt32(Console.ReadLine());
        if(names.ContainsKey(checkKey)) Console.WriteLine($"the value {checkKey} is present, it's value is {names[checkKey]}");
        */

        //add odd in oddList , even in evenList
        List<int>odd=new List<int>();
        List<int>even=new List<int>();
        Console.WriteLine("enter a number : ");
        int giveRange=Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <=giveRange; i++)
        {
            if(i%2==0) even.Add(i);
            else odd.Add(i);
        }
        Console.WriteLine("printing even numbers: ");
        foreach (var item in even)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine(Environment.NewLine+"printing odd numbers: ");
        foreach (var item in odd)
        {
            Console.Write($"{item} ");
        }

        
    }
}