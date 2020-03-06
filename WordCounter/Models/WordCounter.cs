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
  }
}