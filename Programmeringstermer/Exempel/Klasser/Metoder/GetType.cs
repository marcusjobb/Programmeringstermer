using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmeringstermer.Exempel.Klasser.Metoder
{
public class GetType
{
    public void Run(object s)
    {
        //Jämförelse med GetType 
        if (s.GetType() == typeof(string))
            Console.WriteLine("'s' är en sträng");
    }
}
}
