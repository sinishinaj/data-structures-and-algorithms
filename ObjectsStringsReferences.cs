public class ObjectsStringsReferences : MyApp.Program.Exercise {
  required public string name { get; set; }
  public void Run() {
    var Id = MyApp.Program.RequestInput("Please enter the ID of an engine in lower-case!");
    var engineId = Id.ToUpper();
    Console.WriteLine("\nThe following is your engine ID, but in upper-case:\n"+engineId);
  }
}
