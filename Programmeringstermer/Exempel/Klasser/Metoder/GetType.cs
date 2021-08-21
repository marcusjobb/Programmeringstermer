namespace Programmeringstermer.Exempel.Klasser.Metoder.GetType
{
    public class GetType_demo
    {
        public void Run(object s)
        {
            //Jämförelse med GetType
            if (s.GetType() == typeof(string))
                Console.WriteLine("'s' är en sträng");
        }
    }
}