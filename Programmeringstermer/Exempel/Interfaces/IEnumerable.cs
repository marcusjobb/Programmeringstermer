namespace Programmeringstermer.Exempel.Interfaces.CollectionInterfaces
{
    public class Enemies : IEnumerable
    {
        private string[] Names = new string[] { "Master", "Silent", "Cybermen", "Daleks", "Zygons", "Weeping Angels" };

        public IEnumerator GetEnumerator()
        {
            return Names.GetEnumerator();
        }
    }

    public class IEnummeratorDemo
    {
        public void Run()
        {
            Console.WriteLine("Enemies:");
            PrintEnemies(new Enemies());
        }

        private void PrintEnemies(IEnumerable beings)
        {
            foreach (var item in beings)
            {
                Console.WriteLine(" " + item);
            }
        }
    }
}