namespace Generic;
class Player{
    public string? ID{get; set;}
    public string? Name{get; set;}
    public string? Sex{get; set;}
    public string? Age{get; set;}
    public string? Height{get; set;}
    public string? Weight{get; set;}
    public string? Team{get; set;}
    public string? NOC{get; set;}
    public string? Games{get; set;}
    public string? Year{get; set;}
    public string? Season{get; set;}
    public string? City{get; set;}
    public string? Sport{get; set;}
    public string? Event{get; set;}
    public string? Medal{get; set;}
}
static class Nepal{
    public static void NepalMethod(IEnumerable<Player> playerFromOurCountry, int countNepal){
        if(countNepal<=100){
            foreach(var x in playerFromOurCountry){
                Console.WriteLine($"{x.ID}\t{x.Name}\t{x.Sex}\t{x.Age}\t{x.Height}\t{x.Weight}\t{x.Team}\t{x.NOC}\t{x.Games}\t{x.Year}\t{x.Season}\t{x.City}\t{x.Sport}\t{x.Event}\t{x.Medal}");
            }
        }
        else{
            FileStream filestream = new FileStream("nepal.txt", FileMode.Create);
            var streamwriter = new StreamWriter(filestream);
            streamwriter.AutoFlush = true;
            foreach(var x in playerFromOurCountry){
                streamwriter.WriteLine($"{x.ID},{x.Name},{x.Sex},{x.Age},{x.Height},{x.Weight},{x.Team},{x.NOC},{x.Games},{x.Year},{x.Season},{x.City},{x.Sport},{x.Event},{x.Medal}");       
            }
            streamwriter.Close();
        }
    }
}
static class China{
    public static void ChinaGold(IEnumerable<Player> playerFromChina, int countChina){
        if(countChina<=100){
            foreach(var x in playerFromChina){
                Console.WriteLine($"{x.ID}\t{x.Name}\t{x.Sex}\t{x.Age}\t{x.Height}\t{x.Weight}\t{x.Team}\t{x.NOC}\t{x.Games}\t{x.Year}\t{x.Season}\t{x.City}\t{x.Sport}\t{x.Event}\t{x.Medal}");
            }
        }
        else{
            FileStream filestream = new FileStream("china.txt", FileMode.Create);
            var streamwriter = new StreamWriter(filestream);
            streamwriter.AutoFlush = true;
            foreach(var x in playerFromChina){
                streamwriter.WriteLine($"{x.ID},{x.Name},{x.Sex},{x.Age},{x.Height},{x.Weight},{x.Team},{x.NOC},{x.Games},{x.Year},{x.Season},{x.City},{x.Sport},{x.Event},{x.Medal}");       
            }
            streamwriter.Close();
        }
    }
}
static class USA{
    public static void USA_Method(IEnumerable<Player> playerFromUSA, int countUSA){
        if(countUSA<=100){
            foreach(var p in playerFromUSA){
                
                Console.WriteLine($"{p.ID}\t{p.Name}\t{p.Sex}\t{p.Age}\t{p.Height}\t{p.Weight}\t{p.Team}\t{p.NOC}\t{p.Games}\t{p.Year}\t{p.Season}\t{p.City}\t{p.Sport}\t{p.Event}\t{p.Medal}");
                
            }
        }
        else{
            FileStream filestream = new FileStream("usa.txt", FileMode.Create);
            var streamwriter = new StreamWriter(filestream);
            streamwriter.AutoFlush = true;
            foreach(var p in playerFromUSA){
                
                streamwriter.WriteLine($"{p.ID},{p.Name},{p.Sex},{p.Age},{p.Height},{p.Weight},{p.Team},{p.NOC},{p.Games},{p.Year},{p.Season},{p.City},{p.Sport},{p.Event},{p.Medal}");
                
            }
            streamwriter.Close();
        }
    }
}

// static class Gold{
//     public static void CountryGold(IOrderedEnumerable<Player>? countryGold, int countGold){
//         if(countGold<=100){
//             foreach(var p in countryGold){
                
//                 Console.WriteLine($"{p.noc}\t\t\t{p.gold}");
                
//             }
//         }
//         else{
//             FileStream filestream = new FileStream("gold.txt", FileMode.Create);
//             var streamwriter = new StreamWriter(filestream);
//             streamwriter.AutoFlush = true;
//             foreach(var p in countryGold){
                
//                 streamwriter.WriteLine($"{p.noc},{p.gold}");
                
//             }
//             streamwriter.Close();
//         }
//     }
// }