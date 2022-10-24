namespace Testing;
public class Test{
    public static int checkForALetter(List<string> stringList, string letter){
        //WRITE YOUR CODE HERE
        int count = 0;
        for (int i = 0; i < stringList.Count; i++){
            foreach(char c in stringList[i]){
                if (c.ToString() == letter){
                    count++;
                }
            }
        }
        
        return count;
        
    }
    //DO NOT TOUCH THE CODE BELOW
    public static void Main(){
        string[] inputArray = Console.ReadLine().Replace("[","").Replace("]","").Split(",");
        string letter = Console.ReadLine();
		List<string> stringList = new List<string>();
		for(int i=0;i<inputArray.Length;i++){
		    stringList.Add(inputArray[i]);
		}
        Console.WriteLine(checkForALetter(stringList, letter));
    }
}