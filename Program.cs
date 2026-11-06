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
string b= "123";
 var c=int.Parse(b);
 Console.WriteLine(c + 100);
 var tot= 35;
 if(tot> 30)
 {
    Console.WriteLine("lessthan");
 }
 else
 {
    Console.WriteLine("greater");
 }
  switch(tot)
  {
    case 30:
        Console.WriteLine("greater 30");
        break;
   case 35: 
      Console.WriteLine("greater 35");
      break;
   default:
    Console.WriteLine("good");
    break;
  }
  
