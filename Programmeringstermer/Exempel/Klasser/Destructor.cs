using System;

namespace Programmeringstermer.Exempel.Destructor
{
    internal class MinClass
    {
        ~MinClass()
        {
            Console.WriteLine("Nu är min class död");
        }
    }

    //public void main()
    //{
    //    MinClass MC = new MinClass();
    //    MC = null; // döda klassen
    //               // Köra igång Garbage collectorn
    //               // annars kommer Destructorn att triggas
    //               // först när main() avslutas
    //    System.GC.Collect();
    //}
}