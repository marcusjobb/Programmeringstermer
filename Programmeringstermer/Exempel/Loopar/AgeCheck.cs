namespace Programmeringstermer.Exempel.Loopar.DoLoop
{
    public class AgeCheck
    {
        public void Run()
        {
            //Kollar om personen är myndig
            //Man vet inte antalet frågor som ska ställas, det kan vara en
            //och det kan bli 100, beroende på svaren som datorn får.

            // Initieras inte innan loop
            int age;
            do
            {
                Console.Write("Hur gammal är du? ");
                age = int.Parse(Console.ReadLine());
            } while (age < 18);
            Console.WriteLine("Ok, du är myndig.");
        }
    }
}