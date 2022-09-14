// See https://aka.ms/new-console-template for more information
//Använd följande kod:
//string[] cars = { "Ford", "Cadillac", "Audi" };
//Använd Sort-metoden (googla) för att sortera bilmärkena i bokstavsordning.
//Skriv ut bilmärkena utan att använda dig av iteration.

string[] cars = { "Ford", "Cadillac", "Audi" };
Array.Sort(cars);
Console.WriteLine(string.Join(',', cars));
Console.WriteLine("\n");

//Använd följande kod:
//int[] numbers = { 12, 50, 72 };
//Addera talen med hjälp av en for-loop.
//Skriv ut summan

int[] numbers = { 12, 50, 72 };
int summa = 0;
for (int i = 0; i < numbers.Length; i++)
{
    summa += numbers[i];
}
Console.WriteLine(summa);
Console.WriteLine("\n");

//Deklarera en string array.
//Tilldela den fem filmtitlar.
//Använd Sort-metoden för att sortera titlarna i bokstavsordning.
//Skriv ut filmtitlarna med hjälp av en for-loop.

string[] movies = { "Titanic", "Lord of the rings", "Matrix", "Die hard", "Angels and Demons" };
Array.Sort(movies);
//foreach (string movie in movies)
//    Console.WriteLine(movie);
for (int i = 0; i < movies.Length; i++)
    Console.WriteLine(movies[i]);
Console.WriteLine("\n");

//Skapa en tvådimensionell array (googla) innehållande boktitel och pris för tre
//böcker.
//Skriv ut informationen till användaren med hjälp av en for-loop

string[,] books = { { "Book1", "100" }, { "Book2", "99" }, { "Book3", "120" } };
for (int i = 0; i < books.GetLength(0); i++)
    for (int j = 0; j < books.GetLength(1); j++)
        Console.WriteLine(books[i, j]);
Console.WriteLine("\n");

//Skapa ett nytt projekt av typen Console App.
//Deklarera en array med fem minnesplatser som du döper till animals.
//Tilldela den namnen på fem djurarter.
//Skriv ut namnen på djurarterna med hjälp av en foreach-loop.
//Se output-exempel på nästa sida.
//OUTPUT:
//I djurparken finns:
//björn
//varg
//älg
//ekorre
//säl

string[] animals = new string[5];
animals[0] = "björn";
animals[1] = "varg";
animals[2] = "älg";
animals[3] = "ekorre";
animals[4] = "säl";
Console.WriteLine("I djurparken finns: ");
foreach (string animal in animals)
    Console.WriteLine(animal);
Console.WriteLine("\n");

//Skapa ett nytt projekt av typen Console App.
//Deklarera en array med fem minnesplatser som du döper till contactDetails.
//Tilldela den förnamn, efternamn, adress, telefonnummer och e-postadress.
//Skriv ut informationen utan att använda dig av iteration.
//Se output-exempel på nästa sida.
//OUTPUT:
//Mina kontaktuppgifter:

//Förnamn: Ludwig
//Efternamn: van Beethoven
//Adress: Bonngasse 24 - 26, 53111 Bonn
//Telefon: +49 - (0)228 - 98175 - 25
//E - post museum @beethoven.de

string[] contactDetails = new string[5];
contactDetails[0] = "Ludwig";
contactDetails[1] = "van Beethoven";
contactDetails[2] = "Bonngasse 24 - 26, 53111 Bonn";
contactDetails[3] = "+49 - (0)228 - 98175 - 25";
contactDetails[4] = "museum @beethoven.de";
Console.WriteLine("Mina kontaktuppgifter: " +
                    "\nFörnamn: " + contactDetails[0] +
                    "\nEfternamn: " + contactDetails[1] +
                    "\nAdress: " + contactDetails[2] +
                    "\nTelefon: " + contactDetails[3] +
                    "\nE-post: " + contactDetails[4]);