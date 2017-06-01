using Xunit;
namespace Scrapple.Objects
{
    public class TestScrapple
    {
      // [Fact]
      // public void Test1_GetUserInput_ReturnTrue()
      // {
      //   //Arrange
      //   ScrappleWord newWord = new ScrappleWord("hello");
      //
      //   //Act
      //   string word = newWord.GetWord();
      //
      //   //Assert
      //   Assert.Equal("hello", word);
      // }
      [Fact]
      public void Test2_SplitWordIntoLetters_ReturnTrue()
      {
        //Arrange
        ScrappleWord newWord = new ScrappleWord("hello");
        char[] expectedLetters = new char[] {'h','e','l','l','o'};

        //Act
        string word = newWord.GetWord();
        char[] letters = newWord.Score(word);

        //Assert
        Assert.Equal(expectedLetters, letters);
      }
    }
}
