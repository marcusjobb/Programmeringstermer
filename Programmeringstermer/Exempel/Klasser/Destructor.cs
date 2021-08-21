namespace Programmeringstermer.Exempel.Klasser.Destructor
{
    internal class Destructor_demo
    {
        ~Destructor_demo()
        {
            Console.WriteLine("Nu är min class död");
        }
    }

    //public void main()
    //{
    //    // Instansiera klass
    //    Destructor_demo demo = new Destructor_demo();
    //    // Döda klassen
    //    demo = null;
    //               // Köra igång Garbage collectorn
    //               // annars kommer Destructorn att triggas
    //               // först när main() avslutas
    //    System.GC.Collect();
    //}
}