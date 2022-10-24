using System;
namespace Testing;
public class Test{
    public static int addTwoNumbers(int x, int y){
        //WRITE YOUR CODE HERE
        return x + y;    
    }

    //DO NOT TOUCH THE CODE BELOW
    public static void Main(){
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine(addTwoNumbers(x,y));
    }
}

