using System;

List <string> länder = new(){"Tyskland", "Belgien", "Nederländerna", "Schweiz", "Albanien"};
List <string> huvudstäder = new(){"Berlin", "Bryssel", "Amsterdam", "Bern", "Tirana"};
List <string> valuta = new(){"Euro", "Euro", "Euro", "Franc", "Lek"};
int i = Random.Shared.Next(4);
Console.WriteLine(länder [i]);
//string choice1 = Console.ReadLine().ToLower();

Console.WriteLine($"Vad är huvudstaden i {länder[i]}?");
Console.WriteLine($"{huvudstäder[i]}");
Console.WriteLine($"Vilken valuta används i {länder[i]}");
Console.WriteLine($"{valuta[i]}");

Console.ReadLine(); 
