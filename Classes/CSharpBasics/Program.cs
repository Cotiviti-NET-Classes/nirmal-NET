// See https://aka.ms/new-console-template for more information
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

using System.Linq;
// using Day2;
// Assignment a =new Assignment();

// Console.WriteLine("Sum "+a.Solution(1,2,3,4).sum);
// Console.WriteLine("Average "+a.Solution(1,2,3,4).avg);

// using Animal;
// Wild wild = new("Tiger",7,"Flesh");
// Console.WriteLine(wild.Eat);
// var a=wild.WildAnimal("Leopard",10);
// Console.WriteLine($"{a.Item1},{a.Item2}");
// string s =File.ReadAllText("story.txt").Replace("\n","").Replace("\r", "");

// int totalCharacters = s.Trim().Length;
// Console.WriteLine(totalCharacters);
// string a = Regex.Replace(s," {2,}"," ");

// int totalWords = a.Split(' ').Length;
// Console.WriteLine(totalWords);
// int totalSentences = a.Split(new char[] { '.','?' }, StringSplitOptions.RemoveEmptyEntries).Length;
// Console.WriteLine(totalSentences);
// int totalVowels = System.Text.RegularExpressions.Regex.Matches(a.ToLower(), "[aeoiu]").Count;
// Console.WriteLine(totalVowels);
// var reg =@"[(~!@#$%^&*()_+\-)]";
// int totalSpecialCharacters = System.Text.RegularExpressions.Regex.Matches(a.ToLower(), $"{reg}").Count;
// Console.WriteLine(totalSpecialCharacters);

// string x = "Hello friends  lkjd     dsfldsf";
// Console.WriteLine(Regex.Replace(x," {2,}"," "));

// var countryMedal = player.Select(x=> new{Team=x.Team, NOC=x.NOC, Medal=x.Medal}).DistinctBy(x=>x.Team).Where(x=>x.Medal=="Gold");
// foreach(var x in eg){
//     Console.WriteLine($"{x.Team}\t{x.NOC}\t{x.Medal}");
// }

// var playerFromUSA = player.Where(x=>x.Medal=="Gold").GroupBy(x=>x.NOC).Count();
// foreach(var x in playerFromUSA){
//     foreach(Player p in x){
//         Console.WriteLine($"{p.ID}\t{p.Name}\t{p.Sex}\t{p.Age}\t{p.Height}\t{p.Weight}\t{p.Team}\t{p.NOC}\t{p.Games}\t{p.Year}\t{p.Season}\t{p.City}\t{p.Sport}\t{p.Event}\t{p.Medal}");
//     }
// }


// List<Play> player = new(){
//     new Play(){ Name = "Ram",Age = "Football",Sub=1},
//     new Play(){ Name = "Shyam",Age ="Football" ,Sub=2},
//     new Play(){ Name = "Shyam",Age ="Football" ,Sub=3},
//     new Play(){ Name = "Shyam",Age ="batminton" ,Sub=4},
//     new Play(){ Name = "Shyam",Age ="batminton",Sub=5}
// };
// var m= player.Where(x=>x.Name=="Shyam").OrderBy(x=>x.Age).GroupBy(x=>x.Age);
// // Console.WriteLine(m);
// foreach(var y in m){
//     foreach(Play p in y){
//         Console.WriteLine($"{p.Name}\t{p.Age}\t{p.Sub}");
//     }
    
// }
