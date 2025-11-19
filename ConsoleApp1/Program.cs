// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System.Reflection;

Console.WriteLine("I AM BEUTIFUL, HAPPY, HEALTHY");
var Games = new List<Game> 
{ 
    new Game { title = "Basketball", Genre = "A" , Rating = 5 , ReleaseYear = 2025 , Price = 50},
    new Game { title = "Kabddi", Genre = "B" , Rating = 6 , ReleaseYear = 2026 , Price = 60},
    new Game { title = "Kho-Kho", Genre = "C" , Rating = 7, ReleaseYear = 2027 , Price = 70},
    new Game { title = "BaseBall", Genre = "D" , Rating = 8 , ReleaseYear = 2028 , Price = 80},
    new Game { title = "Cricket", Genre = "E" , Rating = 9 , ReleaseYear = 2029 , Price = 90},
    new Game { title = "Tennis", Genre = "F" , Rating = 10.87, ReleaseYear = 2030 , Price = 100}
};

//List<string> AllGame = new List<string>();

//foreach (var Game in Games)
//{
//    AllGame.Add(Game.title);
//}
//foreach( var title in AllGame)
//{
//    Console.WriteLine(title);
//}
//List<string> AllGame = Games.Select(g => g.title).ToList();
//foreach (var title in AllGame)
//{
//    Console.WriteLine(title);

//}

//var Allgame = Games.Where(g => g.Genre == "E");
//foreach( var game in Allgame)
//{
//    Console.WriteLine(game.title);
//}
//var Allgame = Games.Any(g => g.ReleaseYear >= 2025);
//Console.WriteLine($"Are there any game exist above 2025 year : {Allgame}");

//var Allgame = Games.OrderBy(g => g.ReleaseYear);
//foreach (var game in Allgame)
//{
//    Console.WriteLine($"{game.title} , {game.Genre}");
//}
//double Allgame = Games.Average(g => g.ReleaseYear);
//Console.WriteLine($"Average year is : {Allgame}");

//var Allgame = Games.Max(x => x.Genre);
//foreach( var game in Allgame)
//{
//    Console.WriteLine($"{Allgame}");
//}

//var Allgame = Games.Where(g => g.Price >= 30);
//foreach (var price in Allgame)
//{
//    Console.WriteLine($"Price is greator than 30 :{price.title}");
//}
var highestRating = Games.Max(x => x.Rating);
var Allgame = Games.First(g => g.Rating == highestRating);
Console.WriteLine($"this is highest rated game : {Allgame.title}");
//