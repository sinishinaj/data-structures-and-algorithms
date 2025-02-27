using Microsoft.VisualBasic;

public class PracticingArraysAndLists : MyApp.Program.Exercise {
  required public string name { get; set; }
  public void Run() {
    string listInput = MyApp.Program.RequestInput("Please enter a series of integers, or text; all separated with a comma!");
    string[] arrayStrings = listInput.Split(", ");
    if (arrayStrings.Length <= 0){
      arrayStrings = listInput.Split(",");
    }
    List<string> listStrings = arrayStrings.ToList();
    List<int> listNums = ToDigits(RemoveSpaces(listInput).Split(","));
    int[] arrayNums = listNums.ToArray();

    List<string> revereList = MyReverseArrayOrList([], listStrings).toList;
    string[] reverseArray = MyReverseArrayOrList(arrayStrings, []).toArray;
    Console.WriteLine("\n The following is your list, but in reverse order: \n"+string.Join(", ", revereList));
    Console.WriteLine("\n The following is your array, but in reverse order: \n"+string.Join(", ", reverseArray));
    if (arrayNums.Length > 0){
      Console.WriteLine("\n The following is the average of all of your positive integers: \n"+AverageOfPositiveIntegers(arrayNums));
    }
    Console.WriteLine("\n The following is the length of the longest in your list: \n"+LengthOfLongest(listStrings));
    Console.WriteLine("\n The following is your array but equalized through padding:");
    string[] equalizedArray = EqualizeStrings(arrayStrings);
    foreach (string text in equalizedArray){
      Console.WriteLine("\n"+text);
    }
  }
  string RemoveSpaces(string input) {
    string output = "";
    foreach (char character in input){
      if (character != ' '){
        output += character;
      }
    }
    return output;
  }
  List<int> ToDigits(string[] input) {
    List<int> output = new List<int>();
    foreach (string num in input){
      string cleanNum = "";
      foreach (char c in num){
        if (char.IsDigit(c)){
          cleanNum+=c;
        }
      }
      if (cleanNum.Length>0){
        output.Add(int.Parse(cleanNum));
      }
    }
    return output;
  }

  (string[] toArray, List<string> toList) MyReverseArrayOrList(string[] toArray, List<string> toList){
    string[] outputArray = new string[toArray.Length];
    List<string> outputList = [];
    for (int i = 0; i < toArray.Length; i++){
      outputArray[i] = toArray[toArray.Length-1-i];
    }
    for (int i = 0; i < toList.Count; i++){
      outputList.Add(toList[toList.Count-1-i]);
    }

    return (outputArray, outputList);
  }
  int AverageOfPositiveIntegers(int[] toAverage){
    int sum = 0;
    int length = 0;
    foreach (int number in toAverage){
      if (number >= 0)
        sum+=number;
        length++;
    }
    return sum/length;
  }
  int LengthOfLongest(List<string> toLongest){
    int longest = 0;
    foreach (string text in toLongest){
      if (text.Length > longest){
        longest = text.Length;
      }
    }
    return longest;
  }
  int LengthOfLongestInArray(string[] toLongest){
    int longest = 0;
    foreach (string text in toLongest){
      if (text.Length > longest){
        longest = text.Length;
      }
    }
    return longest;
  }
  string[] EqualizeStrings(string[] toEqualize){
    string[] outputArray = new string[toEqualize.Length];
    int longest = LengthOfLongestInArray(toEqualize);
    for (int i = 0; i < toEqualize.Length; i++){
      string text = toEqualize[i];
      for (int x = 0; x < longest-text.Length; x++){
        text = " "+text;
      }
      outputArray[i]=text;
    }
    return outputArray;
  } 
}
