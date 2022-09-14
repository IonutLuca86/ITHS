// See https://aka.ms/new-console-template for more information
//Uppgift 1: It takes Klass
//Er chef vill att ditt team ska hoppa på den “senaste
//hypen” (trots att den pågått sedan ca 80 talet) och vill
//göra om er senaste app, HTML hemsidegeneratorn,
//till en OOP applikation.
//Skapa en klass som heter något i stil med
//“WebsiteGenerator” och låt klassen innehålla de
//metoder som du skapat tidigare. Inga attribut behövs
//(ännu). Se till att det fortfarande går att köra ditt
//program fast att du nu använder ett objekt skapat
//ifrån klassen för att köra metoderna.

//Uppgift 2: Dina
//Egenskaper
//Det finns mycket som skulle kunna gå att förbättra.
//Ser du några delar som skulle kunna lägga in i
//attribut? Dela upp din klass i attribut som innehåller
//data som alltid har samma tillstånd, och metoder som
//sätter ihop din interna data med data ifrån
//paramterarna.

Console.WriteLine("Skriv ditt välkomnst text : ");
string välkomnst = Console.ReadLine();
Console.WriteLine("Hur många nya meddelande vill du skriva? :");
int num = Int32.Parse(Console.ReadLine());
string[] message = new string[num];
for (int i = 0; i < num; i++)
{
    Console.WriteLine($"{i + 1}. Meddelande :");
    message[i] = Console.ReadLine();
}

Console.WriteLine("Din webbsida ska se ut så här : \n");
WebsiteGenerator WebsiteGenerator = new WebsiteGenerator();
//WebsiteGenerator.StartBody();
//WebsiteGenerator.Header1(välkomnst);
//for (int i = 0; i < num; i++)
//{
//    WebsiteGenerator.Message(message[i], i);
//}
//WebsiteGenerator.Body();
//WebsiteGenerator.EndBody();

WebsiteGenerator.printPage(välkomnst, message);
class WebsiteGenerator
{
    string[] startCode = new string[] { "<!DOCTYPE html>", "<html>", "<body>" , "<main>", "<h1>", "<p>", "<b>" };
    string[] endCode = new string[] { "</main>", "</body>", "</html>", "</h1>", "</p>", "</b>" };
    int temp = 1;
    void Header1(string h1)
    {
        Console.WriteLine($"{startCode[4]} Välkomen {h1} ! {endCode[3]}");
    }
    void Message(string msg, int nr)
    {
        Console.WriteLine($"{startCode[5] + startCode[6]} Meddelande {nr}: {endCode[5]} {msg} {endCode[4]}");
    }
    void Body()
    {
        Console.WriteLine($"{startCode[5]}Kurs om C# {endCode[4]}\r\n{startCode[5]}Kurs om Databaser {endCode[4]}");
    }

    void StartBody()
    {
        Console.WriteLine(startCode[0] + "\n" + startCode[1] + "\n" + startCode[2] + "\n" + startCode[3]);
    }
    void EndBody()
    {
        Console.WriteLine(endCode[0] + "\n" + endCode[1] + "\n" + endCode[2] + "\n");
    }

    public void printPage(string h1, string[] mess)
    { 
        StartBody();
        Header1(h1);
        foreach (string s in mess)
        {
            Message(s, temp);
            temp++;
        }
        Body();
        EndBody();
    }
}
