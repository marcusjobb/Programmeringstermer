using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmeringstermer.Exempel.Klasser.Hashvärden
{
class Person
{
    public string Namn { get; set; }
    public string Personnr { get; set; }

    //Overridar HashCode metoden för att ge tillbaka 
    //personnumrets hashcode, istället för classens 
    public override int GetHashCode()
    {
        return this.Personnr.GetHashCode();
    }

    //Overridar Equals metoden 
    //Jämför två Personobjekt mot varandra 
    //baserat på personnummer 
    public override bool Equals(object obj)
    {
        if (obj == null) return false;

        //Kontrollera att objektet som skickades in 
        //är en person 
        if (obj is Person)
        {
            Person Jämför = (Person)obj;
            return this.Personnr == Jämför.Personnr;
        }
        else
        {
            return false;
        }
    }
}

public class Test
{
    public void Run()
    {
        //HashSet är en array utan dubbletter 
        HashSet<Person> Personreg = new HashSet<Person>();
        Person p = new Person();

        //Testperson 1 
        p.Namn = "Kalle";
        p.Personnr = "851012-4455";
        Personreg.Add(p);

        //Testperson 2, har samma personnummer som Testperson 1 
        p = new Person();
        p.Namn = "Johan";
        p.Personnr = "851012-4455";
        Personreg.Add(p);

        foreach (Person person in Personreg)
        {
            Console.WriteLine("{0} {1} {2}",
            person.Namn, person.Personnr, person.GetHashCode());
        }
        //Enbart Testperson 1 skrivs ut 
    }
}
}
