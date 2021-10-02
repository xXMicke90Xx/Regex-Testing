using System;
using System.Text.RegularExpressions;
using System.Text;

namespace Regex_Testing
{
    class Program
    {
       public static void Main(string[] args)
        {

            string test = @" abc*** def
                            1234567890
                            abcdefghijklmnopqrstuvwxyzåäö
                            
                            Micke.N90@hotmail.com
                            micke.n90@hotmail.com
                            micke.n90@hotMail.nEt
                            
                            Mr Micke
                            Mrs Bella   

                            ´Mr. Micke Nilsson";

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
                Console.WriteLine("Tryck på en knapp. . . ");
                Console.ReadLine();
                pattern = "";
                Console.Clear();





                

            }
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
