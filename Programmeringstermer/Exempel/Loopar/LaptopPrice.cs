namespace Programmeringstermer.Exempel.Loopar.WhileLoop
{
    public class LaptopPrice
    {
        public void Run()
        {
            //Försöker hitta ett schysst pris på en dator
            //Här vet man inte hur många gånger man ska loopa

            // Initieras innan loop
            double datorPris = 12500;
            while (datorPris > 8000)
            {
                datorPris *= .98;
            }
            Console.WriteLine("Billigaste datorn går på:{0}", Math.Round(datorPris, 2));
        }
    }
}