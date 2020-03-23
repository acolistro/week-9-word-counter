using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests {
  //change name of test class.
  [TestClass]
  public class WordTests 
  {
    [TestMethod]
    public void ContainsWord_ChecksStringForWord_bool () 
    {
      RepeatCounter test = new RepeatCounter();
      string sentence = "Hello cat";
      string word = "Hell";
      bool result = test.ContainsWord(sentence, word);
      Assert.IsFalse (result);
    }
      [TestMethod]
      public void HowMany_ChecksNumberofSubstringOccurences_int () 
      {
        RepeatCounter test = new RepeatCounter();
        string sentence = "a cat sees a catty category of cats";
        string word = "cat";
        int result = test.HowMany(sentence, word);
        Assert.AreEqual (1, result);
      }

      // [TestMethod]
      // public void Validator_AccountsforCaseAndNonWords_bool () 
      // {
      //   RepeatCounter test = new RepeatCounter();
      //   string word = "cat";
      //   Assert.IsTrue(test.Validator(word));
      // }

      // [TestMethod]
      // public void SentValidator_AccountsforCaseAndNonWords_bool () 
      // {
      //   RepeatCounter test = new RepeatCounter();
      //   string sentence = "asdf";
      //   Assert.IsFalse(test.Validator(sentence));
      // }
    }
  }
