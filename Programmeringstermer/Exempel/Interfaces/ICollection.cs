namespace Programmeringstermer.Exempel.Interfaces.CollectionInterfaces
{
    public class Doctors : ICollection
    {
        private string[] Names = new string[] { "Hartnell", "Troughton", "Pertwee", "TBaker", "Davison", "CBaker", "McCoy", "McGann", "Eccleston", "Tennant", "Smith", "Capaldi", "Whittaker", "Hurndall", "Hurt", "Bradley", "Martin" };
        public int Count { get { return Names.Length; } }

        public bool IsSynchronized { get { return false; } }

        public object SyncRoot { get { return this; } }

        public void CopyTo(Array array, int index)
        {
            Names.CopyTo(array, index);
        }

        public IEnumerator GetEnumerator()
        {
            return Names.GetEnumerator();
        }
    }

    public class ICollectionDemo
    {
        public void Run()
        {
            Console.WriteLine("Doctors:");
            PrintDoctors(new Doctors());
        }

        private void PrintDoctors(ICollection beings)
        {
            // ICollection har Count
            // IEnummerable saknar det
            Console.WriteLine(beings.Count + " found");
            foreach (var item in beings)
            {
                Console.WriteLine(" " + item);
            }
        }
    }
}