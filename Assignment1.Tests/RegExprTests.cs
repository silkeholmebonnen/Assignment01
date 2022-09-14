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

            [Fact]
    public void Resolution_should_return_tuples_of_input_resolutions()
    {
        // Given
        var testString = "1920x1080";
    
        // When
        var result = RegExpr.Resolution(testString);


        // Then
        result.Should().BeEquivalentTo(new List<(int, int)>{(1920, 1080)});
    }

    [Fact]
    public void Resolution_should_return_tuples_of_input_resolutions_multiple_res()
    {
        // Given
        var testString = "1920x1080, 860x220, 720x300" ;
    
        // When
        var result = RegExpr.Resolution(testString);


        // Then
        result.Should().BeEquivalentTo(new List<(int, int)>{(1920, 1080), (860, 220), (720, 300)});
    }
    [Fact]
    public void Innertext_should_find_innertext_of_specific_tag_a()
    {
        // Given
        var testString = "<div> <p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=\"https://en.wikipedia.org/wiki/Theoretical_computer_science\" title=\"Theoretical computer science\">theoretical computer science</a>" ;
    
        // When
        var result = RegExpr.InnerText(testString, "a");


        // Then
        result.Should().BeEquivalentTo(new List<string>{"theoretical computer science"});

    }

    [Fact]
    public void Innertext_should_find_innertext_of_specific_tag_b()
    {
        // Given
        var testString = "<div> <p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=\"https://en.wikipedia.org/wiki/Theoretical_computer_science\" title=\"Theoretical computer science\">theoretical computer science</a> and <a href=\"https://en.wikipedia.org/wiki/Formal_language\" title=\"Formal language\">formal language</a> theory, a sequence of <a href=\"https://en.wikipedia.org/wiki/Character_(computing)\" title=\"Character (computing)\">characters</a> that define a <i>search <a href=\"https://en.wikipedia.org/wiki/Pattern_matching\" title=\"Pattern matching\">pattern</a></i>. Usually this pattern is then used by <a href=\"https://en.wikipedia.org/wiki/String_searching_algorithm\" title=\"String searching algorithm\">string searching algorithms</a> for \"find\" or \"find and replace\" operations on <a href=\"https://en.wikipedia.org/wiki/String_(computer_science)\" title=\"String (computer science)\">strings</a>.</p></div>";
    
        // When
        var result = RegExpr.InnerText(testString, "b");


        // Then
        result.Should().BeEquivalentTo(new List<string>{"regular expression", "regex", "regexp", "rational expression"});

    }

    [Fact]
    public void Urls_should_return_url_and_title_one_url()
    {
        // Given
        //var testString = "<div> <p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=\"https://en.wikipedia.org/wiki/Theoretical_computer_science\" title=\"Theoretical computer science\">theoretical computer science</a> and <a href=\"https://en.wikipedia.org/wiki/Formal_language\" title=\"Formal language\">formal language</a> theory, a sequence of <a href=\"https://en.wikipedia.org/wiki/Character_(computing)\" title=\"Character (computing)\">characters</a> that define a <i>search <a href=\"https://en.wikipedia.org/wiki/Pattern_matching\" title=\"Pattern matching\">pattern</a></i>. Usually this pattern is then used by <a href=\"https://en.wikipedia.org/wiki/String_searching_algorithm\" title=\"String searching algorithm\">string searching algorithms</a> for \"find\" or \"find and replace\" operations on <a href=\"https://en.wikipedia.org/wiki/String_(computer_science)\" title=\"String (computer science)\">strings</a>.</p></div>";
        var testString = "<a href=\"https://www.w3schools.com/\"  title=\"Hello\">Visit W3Schools.com!</a>";

        // When
        var result = RegExpr.Urls(testString);

        // Then
        //result.Should().BeEquivalentTo(new List<(Uri, string) >{(new Uri("https://en.wikipedia.org/wiki/Theoretical_computer_science"), "Theoretical computer science") , (new Uri("https://en.wikipedia.org/wiki/Formal_language"),"Formal language)") , (new Uri("https://en.wikipedia.org/wiki/Character_(computing)"),"Character (computing)"), (new Uri("https://en.wikipedia.org/wiki/Pattern_matching"),"Pattern matching"), (new Uri("https://en.wikipedia.org/wiki/String_searching_algorithm"), "String searching algorithm"), (new Uri("https://en.wikipedia.org/wiki/String_(computer_science)"), "String (computer science)")});
        result.Should().BeEquivalentTo(new List<(Uri, string) >{(new Uri("https://www.w3schools.com/"), "Hello")});

    }

    [Fact]
    public void Urls_should_return_url_and_innertext_one_url()
    {
        // Given
        //var testString = "<div> <p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=\"https://en.wikipedia.org/wiki/Theoretical_computer_science\" title=\"Theoretical computer science\">theoretical computer science</a> and <a href=\"https://en.wikipedia.org/wiki/Formal_language\" title=\"Formal language\">formal language</a> theory, a sequence of <a href=\"https://en.wikipedia.org/wiki/Character_(computing)\" title=\"Character (computing)\">characters</a> that define a <i>search <a href=\"https://en.wikipedia.org/wiki/Pattern_matching\" title=\"Pattern matching\">pattern</a></i>. Usually this pattern is then used by <a href=\"https://en.wikipedia.org/wiki/String_searching_algorithm\" title=\"String searching algorithm\">string searching algorithms</a> for \"find\" or \"find and replace\" operations on <a href=\"https://en.wikipedia.org/wiki/String_(computer_science)\" title=\"String (computer science)\">strings</a>.</p></div>";
        var testString = "<a href=\"https://www.w3schools.com/\" >Visit W3Schools.com!</a>";

        // When
        var result = RegExpr.Urls(testString);

        // Then
        //result.Should().BeEquivalentTo(new List<(Uri, string) >{(new Uri("https://en.wikipedia.org/wiki/Theoretical_computer_science"), "Theoretical computer science") , (new Uri("https://en.wikipedia.org/wiki/Formal_language"),"Formal language)") , (new Uri("https://en.wikipedia.org/wiki/Character_(computing)"),"Character (computing)"), (new Uri("https://en.wikipedia.org/wiki/Pattern_matching"),"Pattern matching"), (new Uri("https://en.wikipedia.org/wiki/String_searching_algorithm"), "String searching algorithm"), (new Uri("https://en.wikipedia.org/wiki/String_(computer_science)"), "String (computer science)")});
        result.Should().BeEquivalentTo(new List<(Uri, string) >{(new Uri("https://www.w3schools.com/"), "Visit W3Schools.com!")});

    }

    [Fact]
    public void Urls_should_return_url_and_title_multiple_urls()
    {
        // Given
        var testString = "<div> <p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=\"https://en.wikipedia.org/wiki/Theoretical_computer_science\" title=\"Theoretical computer science\">theoretical computer science</a> and <a href=\"https://en.wikipedia.org/wiki/Formal_language\" title=\"Formal language\">formal language</a> theory, a sequence of <a href=\"https://en.wikipedia.org/wiki/Character_(computing)\" title=\"Character (computing)\">characters</a> that define a <i>search <a href=\"https://en.wikipedia.org/wiki/Pattern_matching\" title=\"Pattern matching\">pattern</a></i>. Usually this pattern is then used by <a href=\"https://en.wikipedia.org/wiki/String_searching_algorithm\" title=\"String searching algorithm\">string searching algorithms</a> for \"find\" or \"find and replace\" operations on <a href=\"https://en.wikipedia.org/wiki/String_(computer_science)\" title=\"String (computer science)\">strings</a>.</p></div>";

        // When
        var result = RegExpr.Urls(testString);

        // Then
        result.Should().BeEquivalentTo(new List<(Uri, string) >{(new Uri("https://en.wikipedia.org/wiki/Theoretical_computer_science"), "Theoretical computer science") , (new Uri("https://en.wikipedia.org/wiki/Formal_language"),"Formal language") , (new Uri("https://en.wikipedia.org/wiki/Character_(computing)"),"Character (computing)"), (new Uri("https://en.wikipedia.org/wiki/Pattern_matching"),"Pattern matching"), (new Uri("https://en.wikipedia.org/wiki/String_searching_algorithm"), "String searching algorithm"), (new Uri("https://en.wikipedia.org/wiki/String_(computer_science)"), "String (computer science)")});

    }

    [Fact]
    public void Urls_should_return_url_and_title_or_innertext_multiple_urls()
    {
        // Given
        var testString = "<div> <p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=\"https://en.wikipedia.org/wiki/Theoretical_computer_science\" >theoretical computer science</a> and <a href=\"https://en.wikipedia.org/wiki/Formal_language\" title=\"Formal language\">formal language</a> theory, a sequence of <a href=\"https://en.wikipedia.org/wiki/Character_(computing)\">characters</a> that define a <i>search <a href=\"https://en.wikipedia.org/wiki/Pattern_matching\" title=\"Pattern matching\">pattern</a></i>. Usually this pattern is then used by <a href=\"https://en.wikipedia.org/wiki/String_searching_algorithm\" title=\"String searching algorithm\">string searching algorithms</a> for \"find\" or \"find and replace\" operations on <a href=\"https://en.wikipedia.org/wiki/String_(computer_science)\" title=\"String (computer science)\">strings</a>.</p></div>";

        // When
        var result = RegExpr.Urls(testString);

        // Then
        result.Should().BeEquivalentTo(new List<(Uri, string) >{(new Uri("https://en.wikipedia.org/wiki/Theoretical_computer_science"), "theoretical computer science") , (new Uri("https://en.wikipedia.org/wiki/Formal_language"),"Formal language") , (new Uri("https://en.wikipedia.org/wiki/Character_(computing)"),"characters"), (new Uri("https://en.wikipedia.org/wiki/Pattern_matching"),"Pattern matching"), (new Uri("https://en.wikipedia.org/wiki/String_searching_algorithm"), "String searching algorithm"), (new Uri("https://en.wikipedia.org/wiki/String_(computer_science)"), "String (computer science)")});

    }

}