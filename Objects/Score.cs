using System;
using System.Collections.Generic;

namespace Scrapple.Objects
{
  public class ScrappleWord
  {
    private string _word;

    public ScrappleWord(string word)
    {
      _word = word;
    }

    public string GetWord()
    {
      return _word;
    }


  }
}
