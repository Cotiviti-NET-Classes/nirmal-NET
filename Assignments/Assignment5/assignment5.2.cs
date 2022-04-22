using Generic;
namespace Assignment5;
class WorkingPlayer{
     public static void Main()
       {
           var lines=File.ReadAllLines("Player.txt");
            List<Player> player = new();
            foreach(var line in lines){
                var column = line.Split(",");
                player.Add(new Player(){ID=column[0],Name=column[1],Sex=column[2],Age=column[3],Height=column[4],Weight=column[5],Team=column[6],NOC=column[7],
                Games=column[8],Year=column[9],Season=column[10],City=column[11],Sport=column[12],Event=column[13],Medal=column[14]});
            }
            var count = player.Count();
            Console.WriteLine(count);


            var playerFromOurCountry = player.Where(x=> x.NOC=="NEP");
            var countNepal = playerFromOurCountry.Count();
            if(countNepal<=100){
                foreach(var x in playerFromOurCountry){
                    Console.WriteLine($"{x.Team}\t{x.NOC}\t{x.Sport}\t{x.Medal}");
                }
            }

            var playerFromChina = player.Where(x=> x.NOC=="CHN" && x.Medal=="Gold");
            Console.WriteLine(playerFromChina.Count());
            foreach(var x in playerFromChina){
                Console.WriteLine($"{x.ID}\t{x.Name}\t{x.Sex}\t{x.Age}\t{x.Height}\t{x.Weight}\t{x.Team}\t{x.NOC}\t{x.Games}\t{x.Year}\t{x.Season}\t{x.City}\t{x.Sport}\t{x.Event}\t{x.Medal}");
            }

            var p = player.Where(x=>x.NOC=="USA");
            Console.WriteLine(p.Count());
            var playerFromUSA = player.Where(x=>x.NOC=="USA").OrderBy(x=>x.Sport).GroupBy(x=>x.Sport);
            foreach(var x in playerFromUSA){
                foreach(Player p in x){
                    Console.WriteLine($"{p.ID}\t{p.Name}\t{p.Sex}\t{p.Age}\t{p.Height}\t{p.Weight}\t{p.Team}\t{p.NOC}\t{p.Games}\t{p.Year}\t{p.Season}\t{p.City}\t{p.Sport}\t{p.Event}\t{p.Medal}");
                }
            }
       }
}
