
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

bool spelaIgen = true;
bool avsluta = false;
while (spelaIgen) //Programmet börjar om härifrån om man väljer att spela igen.
{
    int i = Random.Shared.Next(4); //Slumpar ett land som ligger i listan
    int score = 0; //Börjar med 0 poäng

    Console.WriteLine($"Det slumpmässiga landet är {länder[i]}"); //Det slumpmässiga landet presenteras
    Console.WriteLine($"Vad är huvudstaden i {länder[i]}?");
    for (int försök = 1; försök < 4; försök++) //Loopen fortsätter köra tills man har gissat 3 gånger
    {

        string huvudstadGissning = Console.ReadLine();

        if (huvudstadGissning.ToLower() == huvudstäder[i].ToLower())
        {
            Rättsvar.KorrektSvar();
            score++;
            break; // Bryt loopen om svaret är korrekt
        }
        else
        {
            Console.WriteLine($"Fel! Försök {försök}/3");
        }


    }
    for (int försök = 1; försök < 4; försök++)
    {
        Console.WriteLine($"Vilken valuta används i {länder[i]}");
        string valutaGissning = Console.ReadLine();
        if (valutaGissning.ToLower() == valuta[i].ToLower())
        {
            Rättsvar.KorrektSvar();
            score++;
            break;
        }
        else
        {
            Console.WriteLine($"Fel! Försök {försök}/3");
        }
            
    }

    for (int försök = 1; försök < 4; försök++)
    {
        Console.WriteLine($"Vad är det mest talade språket i {länder[i]}");
        string språkGissning = Console.ReadLine();
        if (språkGissning.ToLower() == språk[i].ToLower())
        {
            Rättsvar.KorrektSvar();
            score++;
            break;
            
        }
        else
        {
            Console.WriteLine($"Fel! Försök {försök}/3");
        }
            
    }
    Console.WriteLine($"Du fick {score} poäng av 3 möjliga!");
    Console.WriteLine("Vill du spela igen? (ja/nej)");
    spelaIgen = Console.ReadLine().ToLower() == "ja";
    avsluta = Console.ReadLine().ToLower() == "nej";

}
while (avsluta)
{
    break;
}
    




