using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter something: ");
    string input = "";
    while (input ! = "exit")
    {
      input = Console.ReadLine();
      Console.WriteLine("You entered: " + input);
    }
    
  }
}