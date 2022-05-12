// Lav nogle biler
using FindObjektIArray;

Bil[] bilpark = new Bil[4];

bilpark[0] = new();
bilpark[0].Farve = "Blå";
bilpark[0].Mærke = "Ford";
bilpark[0].Nummerplade = "DF30606";

bilpark[1] = new();
bilpark[1].Farve = "Blå";
bilpark[1].Mærke = "Mazda";
bilpark[1].Nummerplade = "AB52643";

bilpark[2] = new();
bilpark[2].Farve = "Blå";
bilpark[2].Mærke = "Ford";
bilpark[2].Nummerplade = "BC63356";

bilpark[3] = new();
bilpark[3].Farve = "Sort";
bilpark[3].Mærke = "Ford";
bilpark[3].Nummerplade = "VF53221";

Console.WriteLine("Hvilken farve biler skal vi finde (prøv med Blå)");
string farve = Console.ReadLine();

Console.WriteLine("Hvilket bilmærke leder vi efter (prøv med Ford)");
string mærke = Console.ReadLine();

foreach (var bil in bilpark)
{
    if (bil.Farve == farve && bil.Mærke == mærke)
    {
        Console.WriteLine($"Fundet: {bil.Nummerplade}");
    }
}