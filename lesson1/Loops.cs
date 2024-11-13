using System;

public class Loops
{
    // Define the method as static
    public static void AllLoops()
    {
        //for loop
        
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("hi harsh "+ i);
        }
        

        Console.Write("how many times u want 2 print hi harsh :");
        int loopCnt=Convert.ToInt32(Console.ReadLine());
        if(loopCnt <=0) Console.WriteLine("please enter a positive number");
        else{
        for (int i = 0; i < loopCnt; i++)
        {
            Console.WriteLine("hi harsh");
        }
        }
        
        Console.Write("what do u want to repeat ? ");
        string msg=Console.ReadLine();
        Console.Write("how many times ? ");
        int loopCnt2=Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < loopCnt2; i++)
        {
            Console.WriteLine(msg);
        }
        
        
        
        
        //if-else with while loop

        Console.Write("give a num1 ");
        int num1=Convert.ToInt32(Console.ReadLine());
        Console.Write("give a num2 ");
        int num2=Convert.ToInt32(Console.ReadLine());
        int ans=num1*num2;
        Console.Write("what do you think " + num1 + "X" + num2 + " will be ?");
        int userAns=Convert.ToInt32(Console.ReadLine());
        while (true)
        {
            if(ans==userAns){
                Console.Write("u r a geniuse");
                break;
            } 
            else{
                Console.Write("u dumb");
                break;
            } 
        }
        
        //do-while

        string name;
       do{
        Console.WriteLine("enter your name :");
        name=Console.ReadLine();
       }while(string.IsNullOrWhiteSpace(name));
        Console.WriteLine("hello " + name);
        
        bool success=true;
        while (true)
        {
            Console.Write("enter a no. ");
            string numInput=Console.ReadLine();
            if(int.TryParse(numInput,out int num)){
                success=false;
                Console.WriteLine(num);
            }else{
                System.Console.WriteLine("failed");
            }
        }
        

        //tables to print according to input
        
        Console.Write("which number tables u want 2 print ?:");
        int numberTable=Convert.ToInt32(Console.ReadLine());
        Console.Write("Till how many times u want 2 print ?:");       
        int tillNum=Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<=tillNum;i++){
            Console.WriteLine("{0} X {1} = {2}",numberTable,i,numberTable*i);
        }
        

        //FizzBuzz Game

        Console.Write("give the number u want 2 find till it : ");        
        int number1=Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<=number1;i++){
            if(i%3==0) Console.WriteLine("IT'S FIZZ ");
            else if(i%5==0) Console.WriteLine("IT'S BUZZ ");
            else Console.WriteLine(i+" ");
        }
       
    }
}

