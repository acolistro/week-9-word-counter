using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests {
  //change name of test class.
  [TestClass]
  public class ChangeNameOfClassTests {
    [TestMethod]
    public void ContainsString_ChecksStringForSubstring_bool () {
      RepeatCounter sentence = new RepeatCounter("Hello world");
      string word = "Hell";
      Assert.IsTrue (sentence.ContainsString(word));
    }

  }
}