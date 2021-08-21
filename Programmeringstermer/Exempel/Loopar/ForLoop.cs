namespace Programmeringstermer.Exempel.Loopar.ForLoop
{
    public class Letters
    {
        public void Run()
        {
            //Skriv ut bokstäver
            for (int räknare = 1; räknare < 27; räknare++)
            {
                Console.Write("{0}", (char)(räknare + 96));
            }
            Console.WriteLine();
        }
    }
}