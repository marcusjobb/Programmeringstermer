namespace Programmeringstermer.Exempel.Klasser.Instansiering
{
    using Programmeringstermer.Exempel.Klasser.Destructor;

    public class Instansiering_demo
    {
        public void Run()
        {
            //Instansiering utan parametrar
            Destructor_demo demo = new Destructor_demo();

            //Instansiering av sträng med 30 streck
            string line = new string('-', 30);

            //Instansiering av en Tuple
            (int, string) tuple = (1337, "leet");
        }
    }
}