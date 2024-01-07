// This is a comment 

//rakendus mis küsib kasutajalt nime 
//rakendus tervitab kasutajat nimepidi

Console.WriteLine("Enter your name:");

string userName;

userName = Console.ReadLine();

//Console.WriteLine("Hello" + ", " + userName + "!");
//string interpolation

Console.WriteLine($"Hello, {userName} !");