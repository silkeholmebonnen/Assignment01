namespace Assignment1.Tests;

public class RegExprTests
{
        [Fact]
    public void splitLine_should_return_list_of_words_from_lines()
    {
        // Given
        var list = new List<string> {"hello Monica", "Silke turned 23", "happy birthday"};
       
    
        // When
        var result = RegExpr.SplitLine(list);


        // Then
        result.Should().BeEquivalentTo(new List<string>{"hello", "Monica", "Silke", "turned", "23", "happy", "birthday"});
    }


}