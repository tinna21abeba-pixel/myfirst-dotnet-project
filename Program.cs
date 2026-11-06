Console.WriteLine("Hello, World!");
Console.WriteLine("Hell abebe");

int x = 10;
decimal y = 20.5m;
string name = "abebe";
bool isTRue = true;
DateTime date = DateTime.Now;

Console.WriteLine(date);

var n = new List<string>();

n.AddRange(new[] { "abebe", "kebede" });

Console.WriteLine(n.Count);

string? anotherName = "almaz";

Console.WriteLine(anotherName ?? "no name");

Console.WriteLine("Write your name:");

var user = Console.ReadLine();

Console.WriteLine($"Hello, {user}");