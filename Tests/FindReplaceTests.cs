using Xunit;
using System.Collections.Generic;
using System;

namespace FindReplaceGame.Objects
{
  public class FindReplaceTest
  {

// Enter a single word sentence and provide replacement of that word
    [Fact]
    public void FindAndReplace_ForReplacingAWordInASingleWordSentence_Goodbye()
    {
      FindReplace testFindReplace = new FindReplace("Hello", "Hello", "Goodbye");
      string expectedReturn = "Goodbye";
      Assert.Equal(expectedReturn, testFindReplace.FindAndReplace());
    }

    // Enter a sentence and provide replacement of one single word from the sentence
    [Fact]
    public void FindAndReplace_ForReplacingAWordInASentence_GoodbyeWorld()
    {
      FindReplace testFindReplace = new FindReplace("Hello World", "Hello", "Goodbye");
      string expectedReturn = "Goodbye World";
      Assert.Equal(expectedReturn, testFindReplace.FindAndReplace());
    }

    // Enter a sentence and provide replacement of a portion of the sentence
    [Fact]
    public void FindAndReplace_ForReplacingAWordInASentence_WhereAreYouSatayingTomorrow()
    {
      FindReplace testFindReplace = new FindReplace("Where are you going today?", "going today", "staying tomorrow");
      string expectedReturn = "Where are you staying tomorrow?";
      Assert.Equal(expectedReturn, testFindReplace.FindAndReplace());
    }

    // Enter a sentence and provide no replacement for replaced word
    // [Fact]
    // public void FindAndReplace_ForReplacingAWordInASentence_TheDogIsCatchingANapAtTheCathedral()
    // {
    //   FindReplace testFindReplace = new FindReplace("The cat is catching a nap at the cathedral", "cat ", "dog ");
    //   string expectedReturn = " The dog is catching a nap at the cathedral";
    //   Assert.Equal(expectedReturn, testFindReplace.FindAndReplace());
    // }

  }
}
