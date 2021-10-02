using System;
using System.Text.RegularExpressions;
using System.Text;

namespace Regex_Testing
{
    class Program
    {
       public static void Main(string[] args)
        {

            string test = " Polisen söker efter en nioårig pojke som försvunnit från Kollegiegatan i Malmö vid 08.15-tiden idag." +
               "Pojken lämnades vid grundskolan på adressen på Kollegiegatan av sin vårdnadshavare, men dök aldrig upp i skolan." +
               " Enligt våra uppgifter har han lämnats vid skolan men inga klasskamrater eller personal har sett honom, säger Evelina Olsson, presstalesperson vid polisregion Syd." +
               "I nuläget finns det ingen misstanke om att pojken utsatts för något brott, men med hänsyn till hans ålder är det önskvärt att han anträffas snarast, uppger polisen. " +
               "Vi arbetar med att kontrollera en rad olika platser som han kan befinna sig på.Rytteriet, vanliga patruller och helikopter arbetar med sökandet, säger Evelina Olsson." +
               "Han ska vara klädd i orangea byxor och en svart munkjacka med vit text. Eventuellt har pojken också en cykel med sig." +
               "Ser du pojken eller har du nyss sett honom bör du kontakta polisen via telefonnummer 112.Tips, observationer eller andra upplysningar mottages tacksamt via telefonnummer 114 14.";

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
