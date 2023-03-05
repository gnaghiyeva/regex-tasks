// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Text.RegularExpressions;
//
Regex rx = new Regex(@"[+]994[-, ]+(50|51|55|70|77|99|10|11|18|20|21|22|23|24|25|26|36)-[0-9]{3}-[0-9]{2}-[0-9]{2}");

Console.Write("Nomreni daxil edin:");
string nomre = Console.ReadLine();

MatchCollection matches = rx.Matches(nomre);

foreach (Match match in matches)
{
    Console.WriteLine("Nomre duzgundur: " + match);
}




