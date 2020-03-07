using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace WordCounter.Models 
{
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
    public bool Validator(string word)
    {
      string[] Words = Directory.GetFiles("./../WordCounter/Models/", "words.txt");
      IEnumerable<string> englishWords = File.ReadLines(Words[0]);
      bool result = englishWords.Contains<string>(word);
      return result;
    }

    public bool SentValidator(string sentence)
    {
      string[] Words = Directory.GetFiles("./../WordCounter/Models/", "words.txt");
      IEnumerable<string> englishWords = File.ReadLines(Words[0]);
      string[] sentArray = sentence.Split(" ");
      for (int i=0; i < sentArray.Length; i++)
      {
        // if ((englishWords.Contains<string>(sentArray[i])) == false)
        // {
        //   string result = Console.WriteLine("Your sentence contains one or more wrong words");
        // }

      }
    }
  }
}
        // return result;
    
  