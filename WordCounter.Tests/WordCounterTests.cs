using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests {
  //change name of test class.
  [TestClass]
  public class ChangeNameOfClassTests 
  {
    [TestMethod]
    public void ContainsString_ChecksStringForSubstring_bool () 
    {
      RepeatCounter test = new RepeatCounter();
      string sentence = "Hello world";
      string word = "llo";
      bool result = test.ContainsString(sentence, word);
      Assert.IsTrue (result);
    }
      [TestMethod]
      public void HowMany_ChecksNumberofSubstringOccurences_int () 
      {
        RepeatCounter test = new RepeatCounter();
        string sentence = "a category of cats";
        string word = "cat";
        int result = test.HowMany(sentence, word);
        Assert.AreEqual (2, result);
      }
    }
  }
