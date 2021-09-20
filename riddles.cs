using System;
using System.Collections.Generic;
using SphinxRiddles;

class Riddle 
{
    static void Main()
    {
    Sphinx questionOne = new Sphinx("What goes all the way around the world, but stays in one corner?", "stamp");
    Sphinx questionTwo = new Sphinx("What has four fingers and a thumb, but isn't alive?", "glove");
    Sphinx questionThree = new Sphinx("What has a head and a tail, but no body?", "coin");
    // Dictionary<string, string>.KeyCollection keys = riddles.Keys;
    List<Sphinx> Sphinx = new List<Sphinx>() {questionOne, questionTwo, questionThree};
    //   AskRiddle();
    // }

    // static void AskRiddle()
    // {
    // Random random = new Random();
    // int index = random.Next(Sphinx.Count);

    // List<Sphinx> SphinxArray = new List<Sphinx>() {};
    // SphinxArray.Add(Sphinx[index]);

    foreach(Sphinx question in Sphinx)
    {
    Random random = new Random();
    int index = random.Next(Sphinx.Count);
    // List<Sphinx> SphinxArray = new List<Sphinx>() {};
    // SphinxArray.Add(Sphinx[index]);
      Console.WriteLine(Sphinx[index].Question);
      string userAnswer = Console.ReadLine();
      if (Sphinx[index].CorrectAnswer(userAnswer))
      {
        Console.WriteLine("Correct!");
        // Sphinx.Remove(Sphinx[index]);
        // AskRiddle();
      }
      else
      {
        Console.WriteLine("nope, go back.");
        Main();
      }
      }
    }
  }
