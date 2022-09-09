namespace Assignment1;

using System.Text.RegularExpressions;

public static class RegExpr
{
    public static IEnumerable<string> SplitLine(IEnumerable<string> lines) {

        foreach(var line in lines){
            var matches =  Regex.Matches(line,@"\w+");

            foreach(Match word in matches){
                yield return word.Value;
            }
        }

        
       
        
    }       

    public static IEnumerable<(int width, int height)> Resolution(string resolutions) 
    {
        throw new NotImplementedException();
    }


    public static IEnumerable<string> InnerText(string html, string tag) 
    {
        throw new NotImplementedException();
    }
}