using System;
using System.Collections.Generic;

class GeografiQuiz 
{

    static List <string> länder = new(){"Tyskland", "Belgien", "Nederländerna", "Schweiz", "Albanien"};
    static List <string> huvudstäder = new(){"Berlin", "Bryssel", "Amsterdam", "Bern", "Tirana"};
    static List <string> valuta = new(){"Euro", "Euro", "Euro", "Franc", "Lek"};

    static void Main(string[] args)
    {
        int i = Random.Shared.Next(4);

        Console.WriteLine($"Det slumpmässiga landet är {länder [i]}");
        
        Console.WriteLine($"Vad är huvudstaden i {länder[i]}?");
        Console.ReadLine();
        Console.WriteLine($"{huvudstäder[i]}");
        Console.WriteLine($"Vilken valuta används i {länder[i]}");
        Console.ReadLine();
        Console.WriteLine($"{valuta[i]}");

        Console.ReadLine(); 
    }
}