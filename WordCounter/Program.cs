using System;
using WordCounter.Models;

namespace WordCounter {
  public class Program {
    public static void Main () 
    {
      RepeatCounter countMe = new RepeatCounter();
      Console.WriteLine ("please enter a sentence:");
      string sentence = Console.ReadLine();
      Console.WriteLine("please enter a word: ");
      string word = Console.ReadLine();
      if (countMe.ContainsString(sentence, word))
      {
        int num = countMe.HowMany(sentence, word);
        Console.WriteLine("The sentence '" + sentence + "' contains " + num + " instances of the word '" + word + "'.");
      }

    }
  }

}