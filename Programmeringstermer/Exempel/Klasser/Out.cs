using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmeringstermer.Exempel.Klasser.Out
{
    public class Cirkel
    {
        public void Run()
        {
            // Standardvärden
            double r = 10;
            double a = 0;
            double c = 0;
            // Anropar metoden
            a = GetCircleData(r, out c);
            // Skriver ut resultatet
            Console.WriteLine("Cirkelns radie är " + r);
            Console.WriteLine("Cirkelns area är " + a);
            Console.WriteLine("Cirkelns omkrets är " + c);
        }

        private double GetCircleData(double radius, out double circumference)
        {
            // Räknar ut arean
            var area = Math.PI * Math.Pow(radius, 2);
            // Räknar ut omkretsen, observera att 
            // variabeln är redan deklarerad, till
            // skillnad från area.
            circumference = 2 * Math.PI * radius;
            // returnerar area, circumference returneras
            // till variabeln circumference i den
            // anropande metoden
            return area;
        }
    }
}
