using Xunit;
namespace Scrapple.Objects
{
    public class TestScrapple
    {
      [Fact]
      public void Test1_GetUserInput_ReturnTrue()
      {
        //Arrange
        ScrappleWord newWord = new ScrappleWord("hEllo");

        //Act
        string word = newWord.GetWord();

        //Assert
        Assert.Equal("hello", word);
      }

      [Fact]
      public void Test2_SplitWordIntoLetters_ReturnTrue()
      {
        //Arrange
        ScrappleWord newWord = new ScrappleWord("hello");
        char[] expectedLetters = new char[] {'h','e','l','l','o'};

        //Act
        string word = newWord.GetWord();
        char[] letters = newWord.SplitWord(word);

        //Assert
        Assert.Equal(expectedLetters, letters);
      }

      [Fact]
      public void Test3_AssignPointToLetter_ReturnTrue()
      {
        //Arrange
        ScrappleWord newWord = new ScrappleWord("hEllO");

        //Act
        string word = newWord.GetWord();
        char[] letters = newWord.SplitWord(word);
        int score = newWord.Score(letters);

        //Assert
        Assert.Equal(2, score);
      }
    }
}
