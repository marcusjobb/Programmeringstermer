namespace Programmeringstermer.Exempel.Kapitelkod.Classer_och_typer.EnumToString
{
    public enum Temperature
    {
        Low = 0,
        Medium = 1,
        High = 2,
        Inferno = 3
    }

    internal class TemperatureTest
    {
        public void Run()
        {
            var morning = (Temperature)0;
            var evening = Temperature.Medium;
            Console.WriteLine("Morning temp is " + morning.ToString());
            Console.WriteLine("Evening temp is " + evening.ToString());
        }
    }
}