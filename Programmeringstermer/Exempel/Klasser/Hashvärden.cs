using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmeringstermer.Exempel.Klasser.Hashvärden
{
    public class Hashvärden_demo
    {
        public void Run()
        {
            //Förbered olika variabler i minnet 
            int x = 5;
            double d = 2.5;
            string a = "a";
            string b = "b";
            string ab = "ab";

            //Skriv ut hashvärdena 
            Console.WriteLine("Typ Värde\t\t\t Hashcode");
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("int : {0}\t\t --> \t{1}", x, x.GetHashCode());
            Console.WriteLine("double : {0}\t\t --> \t{1}", d, d.GetHashCode());
            Console.WriteLine("string : {0}\t\t --> \t{1}", a, a.GetHashCode());
            Console.WriteLine("string : {0}\t\t --> \t{1}", b, b.GetHashCode());
            Console.WriteLine("string : {0}\t\t --> \t{1}", ab, ab.GetHashCode());

            //Resultatet blir detta
            //(värdena förändras varje körning)
            //Typ Värde Hashcode 
            //-------------------------------------------------- 
            //int : 5 --> 5 
            //double : 2,5 --> 1074003968 
            //string : a --> -842352705 
            //string : b --> -842352706 
            //string : ab --> -840386625 
        }
    }
}
