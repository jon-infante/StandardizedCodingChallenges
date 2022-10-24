using System;
namespace Testing;
public class Test{
    public static int rockGame(int b, int s, int t){
        //WRITE YOUR CODE HERE
        
        int i = 0;
        int steveRocks = 0;
        int tommyRocks = 0;
        while (b > 0){
            bool steveOrTommy = ((i % 2) == 0);
            int rockNum = (steveOrTommy) ? s : t;
            b = b - rockNum;
            if(steveOrTommy){
                steveRocks = steveRocks + rockNum;
            }
            else{
                tommyRocks = tommyRocks + rockNum;
            }
            if (b < 0) {
                if(steveOrTommy){ //True is Steve, False is Tommy, checking if we need to readd if we went to negative rocks
                    steveRocks = steveRocks + b;
                }
                else{
                    tommyRocks = tommyRocks + b;
                }
            }
            i++;  
        }
        
        if (i % 2 == 0){ //If its even, tommy was the last to empty the bag. And vice versa

            return tommyRocks;
        }
        else{
            return steveRocks;
        }       
    }


    //DO NOT TOUCH THE CODE BELOW
    public static void Main(){
        int b = int.Parse(Console.ReadLine());
        int s = int.Parse(Console.ReadLine());
        int t = int.Parse(Console.ReadLine());
        Console.WriteLine(rockGame(b,s,t));
    }
}