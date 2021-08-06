using System;

namespace Programmeringstermer.Exempel.Klasser.Metoder.Hashvärden
{
    public class HashvärdenKlass_demo
    {
        public void Run()
        {
            NamnClass mc = new NamnClass();
            NamnClass mc2 = new NamnClass();
            NamnClassPlus mnc = new NamnClassPlus();
            NamnClassPlus mnc2 = new NamnClassPlus();

            mc.Namn = "Jake Sully";
            mc2.Namn = "Jake Sully";

            mnc.Namn = "Neytiri";
            mnc2.Namn = "Neytiri";

            //Skriv ut hashvärdena
            Console.WriteLine("Typ Värde\t\t\t Hashcode");
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("NamnClass1 : {0}\t\t --> \t{1}", mc.Namn, mc.GetHashCode());
            Console.WriteLine("NamnClass2 : {0}\t\t --> \t{1}", mc2.Namn, mc2.GetHashCode());
            Console.WriteLine();
            Console.WriteLine("NamnClassPlus1 : {0}\t --> \t{1}", mnc.Namn, mnc.GetHashCode());
            Console.WriteLine("NamnClassPlus2 : {0}\t --> \t{1}", mnc2.Namn, mnc2.GetHashCode());
            Console.Read();

            //Resultatet blir detta
            //Hashnumret ändras vid varje körning)
            //Typ Värde Hashcode
            //--------------------------------------------------
            //NamnClass1 : Jake Sully --> 45653674
            //NamnClass2 : Jake Sully --> 41149443
            //
            //NamnClassPlus1 : Neytiri --> 1067895399
            //NamnClassPlus2 : Neytiri --> 1067895399

            //NamnClassPlus ger samma Hashvärde om egenskapen namn är likadan
            //Då den baserar sitt hashvärde på egenskapen
            //det gör inte NamnClass!
        }
    }

    internal class NamnClassPlus
    {
        public string Namn { get; internal set; }

        public override int GetHashCode()
        {
            return Namn.GetHashCode();
        }
    }

    internal class NamnClass
    {
        public string Namn { get; internal set; }
    }
}