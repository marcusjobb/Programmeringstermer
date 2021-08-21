namespace Programmeringstermer.Exempel.Loopar.NestedLoops
{
    public class Klocka
    {
        public void Run()
        {
            //Klocka som kommer att köra tills midnatt
            for (int timmar = DateTime.Now.Hour; timmar < 24; timmar++)
            {
                for (int minuter = DateTime.Now.Minute; minuter < 60; minuter++)
                {
                    for (int sekunder = DateTime.Now.Second; sekunder < 60; sekunder++)
                    {
                        Console.SetCursorPosition(10, 10);
                        Console.WriteLine("Klockan är {0:00}:{1:00}:{2:00}",
                        timmar, minuter, sekunder);
                        System.Threading.Thread.Sleep(1000);
                    }
                }
            }
        }
    }
}