// See https://aka.ms/new-console-template for more information
using System;
using System.Text.RegularExpressions;
// using Day2;
// Assignment a =new Assignment();

// Console.WriteLine("Sum "+a.Solution(1,2,3,4).sum);
// Console.WriteLine("Average "+a.Solution(1,2,3,4).avg);

// using Animal;
// Wild wild = new("Tiger",7,"Flesh");
// Console.WriteLine(wild.Eat);
// var a=wild.WildAnimal("Leopard",10);
// Console.WriteLine($"{a.Item1},{a.Item2}");
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
var reg =@"[(~!@#$%^&*()_+\-)]";
int totalSpecialCharacters = System.Text.RegularExpressions.Regex.Matches(a.ToLower(), $"{reg}").Count;
Console.WriteLine(totalSpecialCharacters);

// string x = "Hello friends  lkjd     dsfldsf";
// Console.WriteLine(Regex.Replace(x," {2,}"," "));
