using System;
using System.Text.RegularExpressions;
using System.Text;

namespace Regex_Testing
{
    class Program
    {
       public static void Main(string[] args)
        {

            string test = "Hello My Name Is Mike"; 
            string pattern;
            
            ConsoleKeyInfo cki;

            Regex testdel;
            while (true)
            {
                TestText(test);
                Console.WriteLine("Skriv ett sökvärde: ");
                pattern = Console.ReadLine();
                testdel = new Regex(pattern);
                Update(testdel,test );
                Group(testdel, test);
                Console.WriteLine("----------------------");
                
                Console.WriteLine("Tryck på en knapp. . . ");
                Console.ReadLine();
                pattern = "";
                Console.Clear();





              

            }
            Console.ReadLine();

        }

        static void Group(Regex test, string sträng)
        {
            Match match = test.Match(sträng);
            Console.WriteLine("Match?: " + match.Groups[1].Value);
            Console.WriteLine();
            Console.ReadLine();

        }
        static void TestText(string test)
        {
            
            Console.WriteLine(test);
        }
        static void Update(Regex testdel, string test)
        {
            Console.WriteLine("Skriver ut vad den hittar sökningen(Första instansen): " + testdel.Match(test));
            Console.WriteLine("Skriver hur många gånger strängen återfanns: " + testdel.Matches(test).Count);
            Console.WriteLine("Skriver ett boolVärde ifall strängen fanns eller inte: " + testdel.IsMatch(test));
            
            MatchCollection m = testdel.Matches(test);

            foreach (var ms in m)
            {
                Console.WriteLine("Alla funna delar: " + ms);
            }
            Console.WriteLine();
        }
    }
}
