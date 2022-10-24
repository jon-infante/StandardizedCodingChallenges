using System;
namespace Testing;
public class Test{
    public static string funMathFormula(int a, int b, int c, int d){
        //WRITE YOUR CODE HERE
        int res = ((a*b)+(c*d));
        string evenOrOdd =  ((res % 2) == 0) ? "even" : "odd";
        
        return evenOrOdd;

    }

    //DO NOT TOUCH THE CODE BELOW
    public static void Main(){
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine(funMathFormula(a,b,c,d));
    }
}