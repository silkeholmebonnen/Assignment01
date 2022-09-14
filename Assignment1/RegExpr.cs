namespace Assignment1;

using System.Text.RegularExpressions;

public static class RegExpr
{
    public static IEnumerable<string> SplitLine(IEnumerable<string> lines)
    {

        foreach (var line in lines)
        {
            var matches = Regex.Matches(line, @"\w+");

            foreach (Match word in matches)
            {
                yield return word.Value;
            }
        }


    }

    public static IEnumerable<(int width, int height)> Resolution(string resolutions)
    {
        var matches = Regex.Matches(resolutions, @"((?<width>[\d]{1,4}).*?(?<height>[\d]{1,4}).*?)");

        foreach (Match match in matches)
        {

            if (match.Success)
            {
                string width = match.Groups["width"].Value;
                string height = match.Groups["height"].Value;

                yield return ((int.Parse(width), int.Parse(height)));

            }
        }


    }

    public static IEnumerable<string> InnerText(string html, string tag)
    {
        var matches = Regex.Matches(html, @"(<" + tag + @"{1})[^>]*(>{1})(?<innertext>[\w\s]*)");

        foreach (Match match in matches)
        {

            if (match.Success)
            {
                string innertext = match.Groups["innertext"].Value;

                yield return (innertext);
            }
        }
    }

    public static IEnumerable<(Uri url, string title)> Urls(string html)
    {
        var matches = Regex.Matches(html, @".*?href=""(?<url>\S*)"".*?(title=""(?<title>.*?)"".*?)?>(?<innerText>.*?)<");

        foreach (Match match in matches)
        {

            if (match.Success)
            {
                string stringUrl = match.Groups["url"].Value;
                Uri url = new Uri(stringUrl);
                string innerText = match.Groups["innerText"].Value;
                string title = match.Groups["title"].Value;

                if (title != "") yield return ((url, title));
                else yield return ((url, innerText));

            }
        }
    }


}
