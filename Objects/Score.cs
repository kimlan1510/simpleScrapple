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

    public char[] SplitWord(string word)
    {
      char[] letterArray = word.ToUpper().ToCharArray();
      return letterArray;
    }

    public int Score(char[] letterArray)
    {
      int points = 0;
      foreach(char letter in letterArray)
      {
        if(letter == 'A' || letter == 'E'  || letter == 'I'|| letter == 'O' || letter == 'U'  || letter == 'L' || letter == 'N' || letter == 'R'  || letter == 'S' || letter == 'T' )
        {
          points += 1 ;
        }
        else if(letter == 'D' || letter == 'G')
        {
          points += 2;
        }
        else if(letter == 'B' || letter == 'C'  || letter == 'M'|| letter == 'P')
        {
          points += 3;
        }
        else if(letter == 'F' || letter == 'H'  || letter == 'V'|| letter == 'W' || letter == 'Y')
        {
          points += 4;
        }
        else if(letter == 'K')
        {
          points += 5;
        }
        else if(letter == 'J' || letter == 'X')
        {
          points += 8;
        }
        else if(letter == ' ')
        {
          points += 0;
        }
        else{
          points += 10;
        }
      }
      return points;
    }


  }
}
