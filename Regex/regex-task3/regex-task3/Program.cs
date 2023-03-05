// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;


Regex rx = new Regex(@"[\w\W]+\w@code.edu.az");

Console.Write("email unvanini daxil edin:");
string email = Console.ReadLine();

MatchCollection matches = rx.Matches(email);
foreach (Match match in matches)
{
    Console.Write("e-mail unvani dogrudur  "+ match);
    
}

