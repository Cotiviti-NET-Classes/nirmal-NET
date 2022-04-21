using System;
using System.Text.RegularExpressions;
namespace Assignment4;
class WorkingFile{
     public static void Main()
       {
            string s =File.ReadAllText("story.txt").Replace("\n","").Replace("\r", "");

            int totalCharacters = s.Trim().Length;
            Console.WriteLine(totalCharacters);
            string a = Regex.Replace(s," {2,}"," ");

            int totalWords = a.Split(' ').Length;
            Console.WriteLine(totalWords);
            int totalSentences = a.Split(new char[] { '.','?' }, StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine(totalSentences);
            int totalVowels = System.Text.RegularExpressions.Regex.Matches(a.ToLower(), "[aeoiu]").Count;
            Console.WriteLine(totalVowels);
            int totalSpecialCharacters = System.Text.RegularExpressions.Regex.Matches(a.ToLower(), @"[[(~!@#$%^&*()_+\-)]]").Count;
            Console.WriteLine(totalSpecialCharacters);
       }


}