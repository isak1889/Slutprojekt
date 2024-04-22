



List<string> länder = new() { "Tyskland", "Belgien", "Nederländerna", "Schweiz", "Albanien" };
List<string> huvudstäder = new() { "Berlin", "Bryssel", "Amsterdam", "Bern", "Tirana" };
List<string> valuta = new() { "Euro", "Euro", "Euro", "Franc", "Lek" };
List<string> språk = new() {"Tyska","Flammländska", "Holländska", "Tyska", "Albanska"};

Console.WriteLine("Välkommen till spelet! Vad heter du?");
string namn = Console.ReadLine();

if (namn == "noname")
{
    Console.WriteLine("Välkommen!");
    Console.WriteLine("Du kommer att få ett slumpässigt land som du ska gissa vilket som är landets huvudstad, vilken valuta som används och landets befolkning");
}
else
{
    Console.WriteLine("Välkommen, " + namn + "!");
    Console.WriteLine("Du kommer att få ett slumpässigt land som du ska gissa vilket som är landets huvudstad, vilken valuta som används och landets befolkning");
}

int i = Random.Shared.Next(4); //Slumpar ett land som ligger i listan
int score = 0;

Console.WriteLine($"Det slumpmässiga landet är {länder[i]}");
Console.WriteLine($"Vad är huvudstaden i {länder[i]}?");
for (int försök = 1; försök < 4; försök++)
 {

    string huvudstadGissning = Console.ReadLine();

    if (huvudstadGissning.ToLower() == huvudstäder[i].ToLower())
    {
        Utils.KorrektSvar();
        score++;
        //break; // Bryt loopen om svaret är korrekt
    }
    else
    {
        Console.WriteLine($"Fel! Försök igen. Försök {försök}/3");
    }


}
for (int försök = 1; försök < 4; försök++)
{
    Console.WriteLine($"Vilken valuta används i {länder[i]}");
    string valutaGissning = Console.ReadLine();
    if (valutaGissning.ToLower() == valuta[i].ToLower())
    {
        Utils.KorrektSvar();
        score++;
    }
    else
    {
        Console.WriteLine($"Fel! Försök igen. Försök {försök}/3");
    }
        
}

Console.WriteLine($"Vad är det mest talade språket i {länder[i]}");
for (int försök = 1; försök < 4; försök++)
{
    string språkGissning = Console.ReadLine();
    Console.WriteLine($"Vilken valuta används i {länder[i]}");
    if (språkGissning.ToLower() == språk[i].ToLower())
    {
        Utils.KorrektSvar();
        score++;
    }
    else
    {
        Console.WriteLine($"Fel! Försök igen. Försök {försök}/3");
    }
        
}
Console.WriteLine($"Du fick {score} poäng");


Console.ReadLine();




