//This is a comment to my code

//rakendus küsib kasutaja nime
//ja siis tervitab kasutajat nimepidi

Console.WriteLine("Enter your name:");
//string on sõne
string userName = Console.ReadLine();

Console.WriteLine("Hello, " + userName +"!");
//string interpolation

Console.WriteLine($"Hello, {userName}!");
