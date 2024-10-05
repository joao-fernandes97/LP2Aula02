// See https://aka.ms/new-console-template for more information
using ClassVsStruct;

Player p1, p2;
p1 = new Player() { Health = 21.2f, Armor = 53.9f};
p2=p1;
Console.WriteLine("P1: Health={0}, Armor={1}", p1.Health, p1.Armor);
Console.WriteLine("P2: Health={0}, Armor={1}", p2.Health, p2.Armor);

p1.Health = 0; p1.Armor = 0.5f;

Console.WriteLine("P1: Health={0}, Armor={1}", p1.Health, p1.Armor);
Console.WriteLine("P2: Health={0}, Armor={1}", p2.Health, p2.Armor);
