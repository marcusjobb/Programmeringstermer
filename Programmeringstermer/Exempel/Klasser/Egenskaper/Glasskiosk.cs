namespace Programmeringstermer.Exempel.Klasser.Egenskaper.Glasskiosk
{
    //public void main()
    //{
    // Glasskiosk gk = new Glasskiosk();
    // gk.X15 = 10;
    // gk.Pucko = 11;
    // Console.WriteLine("Så många Puckos finns det: {0}",gk.Pucko);
    // Console.WriteLine("Det finns {0} X15",gk.X15);
    //}
    public class Glasskiosk
    {
        private int pucko = 0;
        private int x15 = 0;

        // Här kan man sätta och läsa av värdet på X15 fältet
        public int X15
        {
            get { return x15; }
            set { x15 = value; }
        }

        // Här kan man sätta och läsa av värdet på Pucko fältet
        public int Pucko
        {
            get { return pucko; }
            set { pucko = value; }
        }
    }
}