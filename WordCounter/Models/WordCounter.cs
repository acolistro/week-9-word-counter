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
    public void Validator(string word)
    {
      string[] Words = Directory.GetFiles("../../../../WordCounter/Models", "*.txt");
      IEnumerable<string> englishWords = File.ReadLines(Words[0]);
      bool result = englishWords.Contains<string>(word, englishWords);
    }
        // return result;
    }
  