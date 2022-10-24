using System;
namespace Testing;
public class Test{
    public static bool shouldGetAFee(double balance){
        //WRITE YOUR CODE HERE
        bool feeOrNot = (balance < 100) ? true : false;
        
        return feeOrNot;
        
    }


    //DO NOT TOUCH THE CODE BELOW
    public static void Main(){
        double balance = double.Parse(Console.ReadLine());
        Console.WriteLine(shouldGetAFee(balance).ToString().ToLower());
    }
}