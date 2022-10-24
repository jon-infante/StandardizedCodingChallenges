using System;
namespace Testing;
public class Test{
    public static string createSecretCode(string s){
        //WRITE YOUR CODE HERE
        
        string code = "";

        for (int i = 0; i < s.Length; i++){
            string secretChar = ((int) Char.ToUpper(s[i]) - 64).ToString(); //Converts the character to ascii value for secret string
            if (int.Parse(secretChar) < 10){
                secretChar = "0" + secretChar.ToString();
            }
            code = code + secretChar;
        }
        
        return code;
    }


    //DO NOT TOUCH THE CODE BELOW
    public static void Main(){
        string s = Console.ReadLine();
        Console.WriteLine(createSecretCode(s));
    }
}