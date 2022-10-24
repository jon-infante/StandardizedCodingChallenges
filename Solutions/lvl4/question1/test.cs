namespace Testing;
public class Test{
    public static List<string> alphabetize(List<string> stringList){
        //WRITE YOUR CODE HERE
        for (int i = 0; i < stringList.Count - 1; i++){
            for (int j = 0; j < stringList.Count - 1; j++){
                int compare = string.Compare(stringList[j], stringList[j+1], StringComparison.Ordinal); //Determining which string is lexigraphically ahead of the other
                if (compare >= 1){
                    string temp = stringList[j];
                    stringList[j] = stringList[j + 1];
                    stringList[j + 1] = temp;
                }
            }
        }

        return stringList;
    }


    //DO NOT TOUCH THE CODE BELOW
    public static void Main(){
        string[] inputArray = Console.ReadLine().Replace("[","").Replace("]","").Split(",");
		List<string> stringList = new List<string>();
		for(int i=0;i<inputArray.Length;i++){
		    stringList.Add(inputArray[i]);
		}
		List<string> sortedList = alphabetize(stringList);
		string result = "[";
		for(int i=0;i<sortedList.Count;i++){
		    if(i==sortedList.Count-1){
		       result+=sortedList[i]+"]";
		    }else{
		        result+=sortedList[i]+",";
		    }
		}
        Console.WriteLine(result);
    }
}