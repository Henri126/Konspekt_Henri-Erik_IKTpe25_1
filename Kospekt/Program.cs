



//1. tuvasta sisu võrdluses tühja stringiga, string andmetüüp
using System.ComponentModel;
using System.Diagnostics.Metrics;

//Console.WriteLine("Tere kasutaja, kuidas on sinu nimi?:");
//string nimi = Console.ReadLine();

//if (nimi == "")
//{
//    Console.WriteLine("Sa ei sisestanud oma nime, sadface😒");
//}
//else if (nimi != "")
//{
//    Console.WriteLine("Tere " + nimi + "! häpifeiss 😀😀");
//}
//else
//{
//    Console.WriteLine("Tundmatu sisestus.");
//}

////2 - vahemikud 
//Console.WriteLine(nimi + ", mis on sinu vanus?");
//int kasutajavanus = int.Parse(Console.ReadLine());


//////2.1 mitu tingimus pesastatud ifide abil 
////if (kasutajavanus > 0)
////{
////    if (kasutajavanus < 18)
////    {
////        Console.WriteLine("Enerksi ei saa, oled alakas, Monsterist ilma 😒");
////    }
////    else
////    {
////        Console.WriteLine("Yippie! saad monsut osta 😀😀");
////    }
////}
////2.2 mitu tingimus kasutades loogilist tehet "and"
//    if (kasutajavanus > 0 && kasutajavanus < 18)
//    {
//        Console.WriteLine("Enerksi ei saa, oled alakas, Monsterist ilma 😒");
//    }
//    else
//    {
//        Console.WriteLine("Yippie! saad monsut osta 😀😀");
//    }

////2.3 mitu vahemikku if/else-if abil. andmetüüp double/float/decimal
//Console.WriteLine($"Sisesta oma pikkus ka {nimi}!");
//double kasutajaPikkus = double.Parse(Console.ReadLine());
//if (kasutajaPikkus < 1.00d)
//{
//    Console.WriteLine("Oled Juntsu");
//}
//else if (kasutajaPikkus < 1.25d && kasutajaPikkus > 1.00d)
//{
//    Console.WriteLine("Oled peaaegu allmeetrimees");
//}
//else if (kasutajaPikkus < 1.50d && kasutajaPikkus > 1.25d)
//{
//    Console.WriteLine("OIOI, päkapikk enam ei olegi, " + nimi);
//}
//else if (kasutajaPikkus < 1.75d && kasutajaPikkus > 1.50d)
//{
//    Console.WriteLine(nimi+", oled enamasti standardpikkuses, kui mitte just natkue lühike");
//}
//else if (kasutajaPikkus < 2.00d && kasutajaPikkus > 1.75d)
//{
//    Console.WriteLine(nimi+", oled pikk kolge, vaata et sa pea vastu uksepiita ära ei löö 😘");
//}
//else 
//{
//    Console.WriteLine("Täielik tulnukas! Kuidas pilved välja näevad lähedalt?");
//}

//Console.WriteLine("Tere, sisesta esmine liidetav arv");
//int arv1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Tere, sisesta teine liidetav arv");
//int arv2 = int.Parse(Console.ReadLine());
//Console.WriteLine("sisesta thememärk / * + - ");
//string tehtetüüp = Console.ReadLine();

//int tulemus = 0;
//if (tehtetüüp == "+")
//{
//    tulemus = arv1 + arv2;
//}
//if (tehtetüüp == "-")
//{
//    tulemus = arv1 - arv2;
//}
//if (tehtetüüp == "*")
//{
//    tulemus = arv1 * arv2;
//}
//if (tehtetüüp == "/")
//{
//    tulemus = arv1 / arv2;
//}
//if (tehtetüüp == "^")
//{
//    tulemus = (int)Math.Pow(arv1, arv2);
//}

//Console.WriteLine(tulemus);

//Console.WriteLine($"Palun vabandust {nimi}, aga programmi´edasiseks tööks on parooli vaja");
//string password = Console.ReadLine(); 
//if (password == "MEES1")
//{
//    Console.WriteLine("JES, parool on õige, oled sisse lubadtud");
//}
//else if (password == "saatana" || password == "1234")
//{
//    Console.WriteLine("Parool on sobimatu, see sinu parool kohe kindlasti ei ole.");
//}
//else
//{
//    Console.WriteLine("parool on vale");
//}

//Console.WriteLine("Mis on sinu lemmikvärv?:");
//string favColour = Console.ReadLine();
//if (favColour == "punane")
//{
//    Console.BackgroundColor = ConsoleColor.Red;
//}
//else if (favColour == "roheline")
//{
//    Console.BackgroundColor = ConsoleColor.Green;
//}
//else if (favColour == "kollane")
//{
//    Console.BackgroundColor = ConsoleColor.Yellow;
//}
//else if (favColour == "kollane")
//{
//    Console.BackgroundColor = ConsoleColor.Yellow;
//}
//else if (favColour == "sinine")
//{
//    Console.BackgroundColor = ConsoleColor.Blue;
//}
//else if (favColour == "must")
//{
//    Console.BackgroundColor = ConsoleColor.Black;
//}
//else if (favColour == "valge")
//{
//    Console.BackgroundColor = ConsoleColor.White;
//}
//else if (favColour == "roosta")
//{
//    Console.WriteLine("Kahjuks ei ole roosa saadaval");
//}
//else if (favColour == "oranz")
//{
//    Console.WriteLine("Kahjuks ei ole oranz saadaval");
//}
//else if (favColour == "lilla")
//{
//    Console.WriteLine("Kahjuks ei ole lilla saadaval");
//}
//else
//{

//    Console.WriteLine("ei tea seda värvi");
//}

//Console.WriteLine("The Colour was maybe changed!!!!!!");


///TÖÖ

//Console.WriteLine("Tere kas te tahade mõõta kasti või tünni?");
//string valik = Console.ReadLine();
//if (valik == "tünn")
//{
//    Console.WriteLine("Kas sa tead tünni raadiust (r) või põhja läbimõõtu (d)");
//    string rvõid = Console.ReadLine();
//    Console.WriteLine("Sisesta see mööt:");
//    double mõõt = double.Parse(Console.ReadLine());
//    if (rvõid == "d")
//    {
//        mõõt = mõõt / 2;
//    }
//    else if (rvõid != "r")
//    {
//        Console.WriteLine("Sisend ei ole tuntav");
//    }

//    Console.WriteLine("Kui kõrge on su tünn");
//    int kõrgus = int.Parse(Console.ReadLine());

//    Console.WriteLine("kui paks on tünni kaas?");
//    int kaanepaksus = int.Parse(Console.ReadLine());

//    double tünnipõhiS = Math.PI * (mõõt * mõõt);
//    double mathV = tünnipõhiS * (kõrgus - kaanepaksus);
//    double küljepindala = tünnipõhiS * kõrgus;
//    double kogupindala = (tünnipõhiS * 2) + küljepindala;
//    Console.WriteLine($"Sinu tünn mahutab {mathV} \nTünni küljepindala on {küljepindala} \nKogupindala aga on {kogupindala}");
//}

//else if (valik == "kast")
//{
//    Console.WriteLine("Kas su kast on kuubik (k) või risttahukas (r)?");
//    string kastitüüp = Console.ReadLine();
//    if (kastitüüp == "k")
//    {
//        Console.WriteLine("Sisesta kasti küljepikkus:");
//        double külgA = int.Parse (Console.ReadLine());
//        double kuubik = Math.Pow(külgA, 3);
//        double küljepindala = (külgA * külgA) * 6;
//        double diagonaal = külgA * Math.Sqrt(3);
//        Console.WriteLine($"Sinu kuubik mahutab {kuubik} \nKuubiku küljepindala on {küljepindala} \nDiagonaal aga on {diagonaal}");

//    }

//    else if (kastitüüp == "r")
//    {
//        Console.WriteLine("Mis on sinu kasti kõige pikim külg?:");
//        double pikkKülg = double.Parse(Console.ReadLine());
//        Console.WriteLine("Mis on sinu kasti kõige lühim külg?:");
//        double lühikekülg = double.Parse(Console.ReadLine());
//        Console.WriteLine("Mis on sinu kasti kõrgus?:");
//        double kõrgus = double.Parse(Console.ReadLine());
//        double V = pikkKülg * lühikekülg * kõrgus;
//        double kogupindala = 2 * ((pikkKülg * lühikekülg) + (lühikekülg * kõrgus) + (pikkKülg * kõrgus));
//        double diagonaal = Math.Sqrt((pikkKülg * lühikekülg) + (lühikekülg * kõrgus) + (pikkKülg * kõrgus));
//        Console.WriteLine($"Sinu kasti mahutab {V} \nKasti küljepindala on {kogupindala} \nDiagonaal aga on {diagonaal}");

//        //Console.WriteLine("banana");
//        //// Console -> adressriav moodul või objekt (Roheline)
//        //// . -> midagi selle objekti seest, sarnane windowsi kausta pathis oleva slashiga
//        //// WriteLine -> adressritav funktsioon objektlist Console 
//        //// () -> sulupaar mis omab endas funktsioonile vajaliku infot 
//        ////    -> saab kasutada ka if tingimuslauses oleva tingimuse piiramiseks, ehk teisiõnu "ifi parameeter"
//        //// [] -> tähistab massiive
//        //// {} -> koodiplokk, tavaliselt pärast tingimust või funktsiooni kirjeldust 
//        ////    -> taane aitab arendajal aru saada millelise koodiploki sees, on Vajalik ka kompitaatorile
//        //// "banana" -> parameeter mis antakse funktsioonile Writeline töötlemiseks kaasa
//        //// ; -> iga koodilasue lõppeb komakooloniga 

//        //int muutuja = 3;
//        //// int -> muutuja nime ees olev andmetüübi kirjueldus. See näitab ära mis tüüpi selle muutuja sees on 
//        //// = -> võrdusmärk omistab sellele muutujale mingisuguse väärtuse 
//        //// 3 -> väärtus mis sellele muutujale omistatakse 

//        //int a = 1;
//        //decimal b = 2.0M;
//        //float c = 3.0f;
//        //double d = 4.0d;
//        //char c1 = 'a';
//        //string s = "tekst";
//        //var x = "abc";
//        //var y = 123;
//        //const int z = 3;

//        //int liitimine = 1 + 1;
//        //int lahutamine = 1 - 1;
//        //int korrutamine = 1 * 1;
//        //int jagamine = 1 / 1;
//        //double astendamine = Math.Pow(2, 2);
//        //double juurimine = Math.Sqrt(2);

//        int arv = 0; // sobib
//        string söne = "abc"; // sobib
//        string sisend_string = "abc"; // sobib 

// muutuja nimes ei sobi järgnevad sõnad:
// abstract, as, base, bool, break, byte, case,
// catch, char, checked, class, const, continue, decimal,
// default, delegate, do, double, else, enum, event, 
// explicit, extern, false, finally, fixed, float, for,
// foreach, goto, if, implicit, in, int, 
// interface, internal, is, lock, long, namespace, new,
// null, object, operator, out, overraide, params, 
// private, protected, public, readonly, ref, return, sbyte, 
// sealed, short, sizeof, stackalloc, static, string, struct,
// switch, this, throw, true, try, typeof, uint, 
// unlong, unchecked, unsafe, ushort, using, virtual, void, 
// volatile, while.

// Adresseerime moodulit "Console", punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum 
// mis asub funktsiooni taga olevate sulgude vahel, antud rida lõppeb lasuelõpumärgiga.

//  }
//}

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
// teeme tingimuslasue if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehetüüp" sisu on samal kujul, kui söne "-" 
{
    tulemus = arv1 - arv2;
}
// peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisaldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus lahutudaes



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
