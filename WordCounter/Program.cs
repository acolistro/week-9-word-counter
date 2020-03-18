using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
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
      bool valid = countMe.Validator(word);
      if (valid == false)
      {
        Console.WriteLine("The word you entered is not a word.");
      }
      else if (countMe.ContainsWord(sentence, word))
      {
        int num = countMe.HowMany(sentence, word);
        Console.WriteLine("The sentence '" + sentence + "' contains " + num + " instances of the word '" + word + "'.");
      }
      else
      {
        Console.WriteLine("There are no instances of " + word + " in your sentence.");
      }

    }
  }

}