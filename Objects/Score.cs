using System;
using System.Collections.Generic;

namespace Scrapple.Objects
{
  public class ScrappleWord
  {
    private string _word;
    private int _points;
    public ScrappleWord(string word)
    {
      _word = word;
    }

    public string GetWord()
    {
      return _word;
    }

    public int Score(string word)
    {
      char[] letterArray = word.ToCharArray();
      foreach(char letter in letterArray)
      {
        if(letter == 'A' || letter == 'E'  || letter == 'I'|| letter == 'O' || letter == 'U'  || letter == 'L' || letter == 'N' || letter == 'R'  || letter == 'S' || letter == 'T' )
        {
          _points += 1 ;
        }
      }
      return _points;
    }


  }
}
