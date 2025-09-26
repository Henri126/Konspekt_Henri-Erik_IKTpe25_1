



//1. tuvasta sisu võrdluses tühja stringiga, string andmetüüp
using System.Diagnostics.Metrics;

Console.WriteLine("Tere kasutaja, kuidas on sinu nimi?:");
string nimi = Console.ReadLine();

if (nimi == "")
{
    Console.WriteLine("Sa ei sisestanud oma nime, sadface😒");
}
else if (nimi != "")
{
    Console.WriteLine("Tere " + nimi + "! häpifeiss 😀😀");
}
else
{
    Console.WriteLine("Tundmatu sisestus.");
}

//2 - vahemikud 
Console.WriteLine(nimi + ", mis on sinu vanus?");
int kasutajavanus = int.Parse(Console.ReadLine());


////2.1 mitu tingimus pesastatud ifide abil 
//if (kasutajavanus > 0)
//{
//    if (kasutajavanus < 18)
//    {
//        Console.WriteLine("Enerksi ei saa, oled alakas, Monsterist ilma 😒");
//    }
//    else
//    {
//        Console.WriteLine("Yippie! saad monsut osta 😀😀");
//    }
//}

//2.2 mitu tingimus kasutades loogilist tehet "and"
    if (kasutajavanus > 0 && kasutajavanus < 18)
    {
        Console.WriteLine("Enerksi ei saa, oled alakas, Monsterist ilma 😒");
    }
    else
    {
        Console.WriteLine("Yippie! saad monsut osta 😀😀");
    }

//2.3 mitu vahemikku if/else-if abil. andmetüüp double/float/decimal
Console.WriteLine($"Sisesta oma pikkus ka {nimi}!");
double kasutajaPikkus = double.Parse(Console.ReadLine());
if (kasutajaPikkus < 1.00d)
{
    Console.WriteLine("Oled Juntsu");
}
else if (kasutajaPikkus < 1.25d && kasutajaPikkus > 1.00d)
{
    Console.WriteLine("Oled peaaegu allmeetrimees");
}
else if (kasutajaPikkus < 1.50d && kasutajaPikkus > 1.25d)
{
    Console.WriteLine("OIOI, päkapikk enam ei olegi, " + nimi);
}
else if (kasutajaPikkus < 1.75d && kasutajaPikkus > 1.50d)
{
    Console.WriteLine(nimi+", oled enamasti standardpikkuses, kui mitte just natkue lühike");
}
else if (kasutajaPikkus < 2.00d && kasutajaPikkus > 1.75d)
{
    Console.WriteLine(nimi+", oled pikk kolge, vaata et sa pea vastu uksepiita ära ei löö 😘");
}
else 
{
    Console.WriteLine("Täielik tulnukas! Kuidas pilved välja näevad lähedalt?");
}

Console.WriteLine("Tere, sisesta esmine liidetav arv");
int arv1 = int.Parse(Console.ReadLine());
Console.WriteLine("Tere, sisesta teine liidetav arv");
int arv2 = int.Parse(Console.ReadLine());
Console.WriteLine("sisesta thememärk / * + - ");
string tehtetüüp = Console.ReadLine();

int tulemus = 0;
if (tehtetüüp == "+")
{
    tulemus = arv1 + arv2;
}
if (tehtetüüp == "-")
{
    tulemus = arv1 - arv2;
}
if (tehtetüüp == "*")
{
    tulemus = arv1 * arv2;
}
if (tehtetüüp == "/")
{
    tulemus = arv1 / arv2;
}
if (tehtetüüp == "^")
{
    tulemus = (int)Math.Pow(arv1, arv2);
}

Console.WriteLine(tulemus);

Console.WriteLine($"Palun vabandust {nimi}, aga programmi´edasiseks tööks on parooli vaja");
string password = Console.ReadLine(); 
if (password == "MEES1")
{
    Console.WriteLine("JES, parool on õige, oled sisse lubadtud");
}
else if (password == "saatana" || password == "1234")
{
    Console.WriteLine("Parool on sobimatu, see sinu parool kohe kindlasti ei ole.");
}
else
{
    Console.WriteLine("parool on vale");
}

Console.WriteLine("Mis on sinu lemmikvärv?:");
string favColour = Console.ReadLine();
if (favColour == "punane")
{
    Console.BackgroundColor = ConsoleColor.Red;
}
else if (favColour == "roheline")
{
    Console.BackgroundColor = ConsoleColor.Green;
}
else if (favColour == "kollane")
{
    Console.BackgroundColor = ConsoleColor.Yellow;
}
else if (favColour == "kollane")
{
    Console.BackgroundColor = ConsoleColor.Yellow;
}
else if (favColour == "sinine")
{
    Console.BackgroundColor = ConsoleColor.Blue;
}
else if (favColour == "must")
{
    Console.BackgroundColor = ConsoleColor.Black;
}
else if (favColour == "valge")
{
    Console.BackgroundColor = ConsoleColor.White;
}
else if (favColour == "roosta")
{
    Console.WriteLine("Kahjuks ei ole roosa saadaval");
}
else if (favColour == "oranz")
{
    Console.WriteLine("Kahjuks ei ole oranz saadaval");
}
else if (favColour == "lilla")
{
    Console.WriteLine("Kahjuks ei ole lilla saadaval");
}
else
{

    Console.WriteLine("ei tea seda värvi");
}

Console.WriteLine("The Colour was maybe changed!!!!!!");

