using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests {
  //change name of test class.
  [TestClass]
  public class ChangeNameOfClassTests {
    [TestMethod]
    public void ContainsString_ChecksStringForSubstring_bool () {
      string sentence = "Hello world";
      string word = "Hell";
      Assert.isFalse (sentence, word);
    }

  }
}