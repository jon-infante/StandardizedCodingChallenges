using System;
namespace Testing;
public class Test{
    public static int findMin(int[] intArray){
        //WRITE YOUR CODE HERE
        int lowest = intArray[0];
        for (int i = 1; i < intArray.Length; i++){
            if (intArray[i] < lowest){
                lowest = intArray[i];
            }
        }
        
        return lowest;
    }


    //DO NOT TOUCH THE CODE BELOW
    public static void Main(){
        string[] inputArray = Console.ReadLine().Replace("[","").Replace("]","").Split(",");
		int[] intArray = new int[inputArray.Length];
		for(int i=0;i<intArray.Length;i++){
		intArray[i]=Int32.Parse(inputArray[i]);
		}
        Console.WriteLine(findMin(intArray));
    }
}