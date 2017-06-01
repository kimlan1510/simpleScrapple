using Xunit;
namespace Scrapple.Objects
{
    public class TestScrapple
    {
      [Fact]
      public void Test1_GetUserInput_ReturnTrue()
      {
        //Arrange
        ScrappleWord newWord = new ScrappleWord("hello");

        //Act
        string word = newWord.GetWord();

        //Assert
        Assert.Equal("hello", word);
      }
    }
}
