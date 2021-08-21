namespace Programmeringstermer.Exempel.Loopar.NestedLoops
{
    public class Weird
    {
        public void Run()
        {
            // Nästlad while-loop som genererar
            // en mysko bild <--->
            int x = 0;
            int y = 0;
            while (x++ < 5)
            {
                Console.Write("<");
                y = 0;
                while (y++ < x)
                {
                    Console.Write("-");
                }
                Console.WriteLine(">");
            }
        }
    }
}