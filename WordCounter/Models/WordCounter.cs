using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace WordCounter.Models 
{
  public class RepeatCounter 
  {
    public bool ContainsWord (string sentence, string word) 
    {
      string[] sentArr = sentence.Split(" ");
      string[] wordArr = Array.FindAll(sentArr, ele => ele.Equals(word));
      bool result = false;
      if (wordArr.Length > 0)
      {
        result = true;
      } 
      return result;
    }

    public int HowMany(string sentence, string word)
    {
      string[] sentArr = sentence.Split(" ");
      string[] wordArr = Array.FindAll(sentArr, ele => ele.Equals(word));
      int result = 0;
      if (wordArr.Length > 0)
      {
        result = wordArr.Length;
      }
      return result;
    }
    // public bool Validator(string word)
    // {
    //   string[] Words = Directory.GetFiles("./~/WordCounter/Models/", "words.txt");
    //   IEnumerable<string> englishWords = File.ReadLines(Words[0]);
    //   bool result = englishWords.Contains<string>(word);
    //   return result;
    // }

    // public bool SentValidator(string sentence)
    // {
    //   string[] Words = Directory.GetFiles("./~/WordCounter/Models/", "words.txt");
    //   IEnumerable<string> englishWords = File.ReadLines(Words[0]);
    //   string[] sentArray = sentence.Split(" ");
    //   List<bool> result = new List<bool>();
    //   bool isValid;
    //   for (int i=0; i < sentArray.Length; i++)
    //   {
    //     if ((englishWords.Contains<string>(sentArray[i])) == false)
    //     {
    //       result.Add(false);
    //     }
    //     else
    //     {
    //       result.Add(true);
    //     }
    //   }
    //   if (result.Contains(false))
    //   {
    //     isValid = false;
    //   }
    //   else
    //   {
    //     isValid = true;
    //   }
    //   return isValid;
    // }
  }
}

    
  