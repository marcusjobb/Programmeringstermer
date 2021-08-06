namespace Programmeringstermer.Exempel.Klasser.Egenskaper.Skrivskyddad
{
    public class API
    {
        public int VersionHigh { get; } = 1; // Egenskaperna är läsbara men inte skrivbara
        public int VersionLow { get; } = 3;// Egenskaperna är läsbara men inte skrivbara

        public API()
        {
            //Egenskaperna är dock skrivbara i constructorn
            VersionHigh = 2;
        }
    }
}