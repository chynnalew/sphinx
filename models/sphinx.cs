using System;

namespace SphinxRiddles {
  public class Sphinx
  {
    public string Question{get; set;}
    public string Answer {get; set;}

    public Sphinx(string question, string answer)
    {
      Question = question;
      Answer = answer;
    }
    public bool CorrectAnswer(string userAnswer)
    {
      userAnswer = userAnswer.ToLower();
      if (Answer.Contains(userAnswer))
      {
        return true;
      }
      else{
        return false;
      }
    }
  }
}
