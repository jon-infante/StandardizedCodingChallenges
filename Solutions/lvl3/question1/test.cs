using System;
namespace Testing;
public class Test{
    public static bool checkForPalindrome(string s){
        //WRITE YOUR CODE HERE
        string sRev = "";
        for (int i = s.Length - 1; i >= 0; i--){
            sRev += s[i];
        }

        if (s == sRev){
            return true;
        }
        else{
            return false;
        } 
    }


    //DO NOT TOUCH THE CODE BELOW
    public static void Main(){
        string s = Console.ReadLine();
        Console.WriteLine(checkForPalindrome(s).ToString().ToLower());
    }
}