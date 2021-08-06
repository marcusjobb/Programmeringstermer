using Programmeringstermer.Exempel.Destructor;

namespace Programmeringstermer.Exempel.Instansiering
{
    public class Instansiering
    {
        public void Run()
        {
            //Instansiering utan parametrar
            MinClass MC = new MinClass();

            //Instansiering av string med 30 streck
            string line = new string('-', 30);

            //Instansiering av en Tuple
            (int, string) tuple = (1337, "leet");
        }
    }
}