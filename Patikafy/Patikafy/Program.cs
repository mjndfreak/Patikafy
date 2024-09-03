using Patikafy;


List<Singer> singerList = new List<Singer>();

Singer singer = new Singer();
singer.Name = "Ajda Pekkan";
singer.Genre = "Pop";
singer.Year = 1968;
singer.Sold = 20;

Singer singer2 = new Singer();
singer2.Name = "Sezen Aksu";
singer2.Genre = "Türk Halk Müziği/Pop";
singer2.Year = 1971;
singer2.Sold = 10;

Singer singer3 = new Singer();
singer3.Name = "Funda Arar";
singer3.Genre = "Pop";
singer3.Year = 1999;
singer3.Sold = 3;

Singer singer4 = new Singer();
singer4.Name = "Sertab Erener";
singer4.Genre = "Pop";
singer4.Year = 1994;
singer4.Sold = 5;

Singer singer5 = new Singer();
singer5.Name = "Sıla";
singer5.Genre = "Pop";
singer5.Year = 2009;
singer5.Sold = 3;

Singer singer6 = new Singer();
singer6.Name = "Serdar Ortaç";
singer6.Genre = "Pop";
singer6.Year = 1994;
singer6.Sold = 10;

Singer singer7 = new Singer();
singer7.Name = "Tarkan";
singer7.Genre = "Pop";
singer7.Year = 1992;
singer7.Sold = 40;

Singer singer8 = new Singer();
singer8.Name = "Hande Yener";
singer8.Genre = "Pop";
singer8.Year = 1999;
singer8.Sold = 7;

Singer singer9 = new Singer();
singer9.Name = "Hadise";
singer9.Genre = "Pop";
singer9.Year = 2005;
singer9.Sold = 5;

Singer singer10 = new Singer();
singer10.Name = "Gülben Ergen";
singer10.Genre = "Türk Halk Müziği/Pop";
singer10.Year = 1997;
singer10.Sold = 10;

Singer singer11 = new Singer();
singer11.Name = "Neşet Ertaş";
singer11.Genre = "Türk Halk Müziği/Türk Sanat Müziği";
singer11.Year = 1960;
singer11.Sold = 2;

singerList.Add(singer);
singerList.Add(singer2);
singerList.Add(singer3);
singerList.Add(singer4);
singerList.Add(singer5);
singerList.Add(singer6);
singerList.Add(singer7);
singerList.Add(singer8);
singerList.Add(singer9);
singerList.Add(singer10);
singerList.Add(singer11);


Console.WriteLine("Artists Starting With S:");
var startingWithS = singerList.Where(s => s.Name.StartsWith("S"));
foreach (var s in startingWithS)
{
    Console.WriteLine(s);
}
Console.WriteLine("-------------------");

Console.WriteLine("Over 10 Million Sold :");
var over10 = singerList.Where(s => s.Sold > 10);
foreach (var s in over10)
{
    Console.WriteLine(s);
}
Console.WriteLine("-------------------");


Console.WriteLine("Before 2000 and Pop:");
var before2mPop = singerList.Where(s => s.Year < 2000 && s.Genre.Contains("Pop"))
    .GroupBy(s => s.Year);
foreach (var group in before2mPop)
{
    Console.WriteLine(group.Key);
    Console.WriteLine("--------------");
    foreach (var s in group)
    {
        Console.WriteLine(s);
        
    }

    Console.WriteLine("\n");
}


Console.WriteLine("Maximum Sales: ");
var maxSold = singerList.OrderByDescending(s => s.Sold).First();
Console.WriteLine(maxSold);


Console.WriteLine("\nLatest Singer:");
var latest = singerList.OrderByDescending(s => s.Year).First();
Console.WriteLine(latest);
Console.WriteLine("\nOldest Singer:");
var oldest = singerList.OrderByDescending(s => s.Year).Last();
Console.WriteLine(oldest);



                                   



    
    

