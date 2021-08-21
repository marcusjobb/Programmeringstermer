using System;

namespace Programmeringstermer.Exempel.Algorithm
{
    public class Random5
    {
        public void Run()
        {
            Random rnd = new Random();
            // Slumptal mellan 0-19
            int x = rnd.Next(20);
            // multiplicera med 2
            int y = x * 2;
            // Addera 10
            y += 10;
            // Dividera med 2
            y /= 2;
            // Minska med originalnumret
            y -= x;
            // Skriv ut 5
            Console.WriteLine(y);
        }
    }
}