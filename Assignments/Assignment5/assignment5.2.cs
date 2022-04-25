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
            var playerFromOurCountry = player.Where(x=> x.NOC=="NEP");
            var countNepal = playerFromOurCountry.Count();

            Nepal.NepalMethod(playerFromOurCountry,countNepal);

            var playerFromChina = player.Where(x=> x.NOC=="CHN" && x.Medal=="Gold");
            var countChina = playerFromChina.Count();
            China.ChinaGold(playerFromChina,countChina);

            var playerFromUSA = player.Where(x=>x.NOC=="USA").OrderBy(x=>x.Sport);
            var countUSA = playerFromUSA.Count();
            USA.USA_Method(playerFromUSA,countUSA);


            var countryGold = player.Where(x=>x.Medal=="Gold").GroupBy(x=>x.NOC).Select(g=> new{noc=g.Key,gold=g.Distinct().Count()}).OrderBy(s=>s.noc);
            var countGold = countryGold.Count();
            if(countGold<=100){
                foreach(var p in countryGold){
                            
                    Console.WriteLine($"{p.noc}\t\t\t{p.gold}");
                            
                }
            }
            else{
                FileStream filestream = new FileStream("gold.txt", FileMode.Create);
                var streamwriter = new StreamWriter(filestream);
                streamwriter.AutoFlush = true;
                foreach(var p in countryGold){
                            
                    streamwriter.WriteLine($"{p.noc},{p.gold}");
                            
                }
                streamwriter.Close();
            }

        }
    }
