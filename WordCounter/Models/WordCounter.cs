using System;

namespace WordCounter.Models {
  //change name of class.
  public class RepeatCounter 
  {
    public bool ContainsString (string sentence, string word) 
    {
      bool result = (sentence.Contains(word));
      return result;
    }

    public int HowMany(string sentence, string word)
    {
      int counter = 0;
      while (sentence.Contains(word))
      {
        sentence = sentence.Remove(sentence.IndexOf(word),word.Length);
        counter += 1;
      }
      return counter;
    }
  }
}