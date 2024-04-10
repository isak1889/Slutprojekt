using System;
using System.Collections.Generic;



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
static void KorrektSvar()
{
    Console.WriteLine("Korrekt!");
    
}

Console.WriteLine($"Det slumpmässiga landet är {länder[i]}");
Console.WriteLine($"Vad är huvudstaden i {länder[i]}?");
for (int försök = 1; försök < 4; försök++)
{
    Console.WriteLine($"Vad är huvudstaden i {länder[i]}?");
    string huvudstadGissning = Console.ReadLine();

    if (huvudstadGissning.ToLower() == huvudstäder[i].ToLower())
    {
        KorrektSvar();
        score++;
        break; // Bryt loopen om svaret är korrekt
    }
    else
    {
        Console.WriteLine($"Fel! Försök igen. Försök {försök}/3");
    }
}
Console.WriteLine($"Vilken valuta används i {länder[i]}");
string valutaGissning = Console.ReadLine();
if (valutaGissning.ToLower() == valuta[i].ToLower())
{
    KorrektSvar();
    score++;
}
else
{
    while (valutaGissning != valuta[i])
    {
        Console.WriteLine("Fel!");
        Console.ReadLine();
        return;
    }
    
}

Console.WriteLine($"Vad är det mest talade språket i {länder[i]}");
string språkGissning = Console.ReadLine();
if (språkGissning.ToLower() == språk[i].ToLower())
{
    KorrektSvar();
    score++;
}
else
{
    while (språkGissning != språk[i])
    {
        Console.WriteLine("Fel!");
        Console.ReadLine();
        return;
    }
    
}




//Console.WriteLine($"{valuta[i]}");


Console.ReadLine();




