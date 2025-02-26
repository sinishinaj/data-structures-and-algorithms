using System;

namespace MyApp
{
  internal class Program
  {
    public interface Exercise 
    {
      public string name { get; set; }
      public void Run();
    }
    static void Main(string[] args)
    {
      ShowExercises();
      var queryExercise = RequestInput("We have concluded this exercise! Would you like to try another? y/n");
      while (queryExercise == "y"){
        ShowExercises();
        queryExercise = RequestInput("We have concluded this exercise! Would you like to try another? y/n");
      }
      Console.WriteLine("\n I'll take that as a no. Very well! Have a good day. Be seeing you on the next one.");
    }

    static void ShowExercises(){
      List<Exercise> exercises = new List<Exercise>();
      exercises.Add(new ObjectsStringsReferences{name="Exercise 1: Objects, strings, and references."});
      exercises.Add(new Encryption{name="Exercise 2: Encryption."});
      exercises.Add(new PracticingArraysAndLists{name="Exercise 3: Practicing arrays, and lists."});

      string listExercises = "";
      foreach (Exercise exercise in exercises){
        listExercises=listExercises + "\n" + exercise.name;
      }
      var queryExercise = Int32.TryParse(RequestInput("Hello! Please enter the index of the desired exercise, with all exercises listed hereunder:\n" + listExercises), out int desiredExercise);
      while (queryExercise == false || desiredExercise-1 < 0 || desiredExercise-1 > exercises.Count){
        queryExercise = Int32.TryParse(RequestInput("Invalid input. You must only input an integer, which must be the index of the exercise from one listed below. This index cannot be zero, or negative. Try again." + listExercises), out desiredExercise);
      }
      Console.WriteLine("\nYou selected, "+exercises[desiredExercise-1].name+"\n");
      exercises[desiredExercise-1].Run();
    }
    public static string RequestInput (string request) {
      Console.WriteLine("\n\n"+request+"\n");
      string input = Console.ReadLine();
      return input;
    }
  }
}