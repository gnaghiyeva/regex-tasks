// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;



//1-ci regexde hemcinin ayin tarixinin herflerle gostermek oldugunu da gosterdim meselen feb 21, 2023
//Regex rx = new Regex(@"([0-9]{1}[-. /]?[0-9]{2}[- ./]?[0-9]{4})|([0-9]{2}[-. /]?[0-9]{2}[- ./]?[0-9]{4})|([0-9]{4}[-. /]?[0-9]{2}[- ./]?[0-9]{2})|([0-9]{2}[-. /]?[0-9]{2}[- ./]?[0-9]{2})|([0-9]{1}[-. /]?[0-9]{2}[- ./]?[0-9]{2})|([0-9]{1}[-. /]?[0-9]{2}[- ./]?[0-9]{4})|([0-9]{2}[-. /]?[0-9]{1}[- ./]?[0-9]{4})|([0-9]{2}[-. /]?[0-9]{1}[- ./]?[0-9]{2})|([a-zA-Z0-9, ]+)");


// burada ancaq reqemler olanlar
Regex rx = new Regex(@"([0-9]{1}[-. /]?[0-9]{2}[- ./]?[0-9]{4})|([0-9]{2}[-. /]?[0-9]{2}[- ./]?[0-9]{4})|([0-9]{4}[-. /]?[0-9]{2}[- ./]?[0-9]{2})|([0-9]{2}[-. /]?[0-9]{2}[- ./]?[0-9]{2})|([0-9]{1}[-. /]?[0-9]{2}[- ./]?[0-9]{2})|([0-9]{1}[-. /]?[0-9]{2}[- ./]?[0-9]{4})|([0-9]{2}[-. /]?[0-9]{1}[- ./]?[0-9]{4})");
Console.Write("Ayin tarixini qeyd edin: ");
string date = Console.ReadLine();

MatchCollection matches = rx.Matches(date);

foreach (Match match in matches)
{
    Console.WriteLine("Ayin tarixi duzgundur " + match);
}