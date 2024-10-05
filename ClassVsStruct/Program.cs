// See https://aka.ms/new-console-template for more information
using ClassVsStruct;

Player p1;
p1 = new Player() { Health = 21.2f, Armor = 53.9f};

Console.WriteLine("P1: Health={0}, Armor={1}", p1.Health, p1.Armor);

DupHealth(p1);

Console.WriteLine("P1: Health={0}, Armor={1}", p1.Health, p1.Armor);

static void DupHealth(Player p)
{
    p.Health *= 2;
}
