using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmeringstermer.Exempel.Interfaces.CollectionInterfaces
{
    public class Enemies : IEnumerable
    {
        string[] Names = new string[] { "Master", "Silent", "Cybermen", "Daleks", "Zygons", "Weeping Angels" };

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
