namespace Assignment1.Tests;

public class IteratorsTests
{

    [Fact]
    public void flatten_takes_stream_of_a_stream_returns_stream()
    {
        // Given

        var list = new List<List<int>> {new List<int> {1,2,3,4},new List<int> {4,2,3,4}};
    
        // When
        var result = Iterators.Flatten(list);


        // Then
        result.Should().BeEquivalentTo(new List<int>{1,2,3,4,4,2,3,4});
    }

     [Fact]
    public void filter_returns_stream_of_true_instances()
    {
        // Given
        var list = new List<int> {4,2,3,4};
        Predicate<int> even = Even; 
        bool Even(int i) => i%2 == 0;
    
        // When
        var result = Iterators.Filter(list, even);


        // Then
        result.Should().BeEquivalentTo(new List<int>{4,2,4});
    }

    

    

}


