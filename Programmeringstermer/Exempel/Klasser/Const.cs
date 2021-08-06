using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Programmeringstermer.Exempel.Klasser.Const
{
    public class ConstExempel
    {
        //----------------------------------------------------- 
        //Exempel på hur man kan använda constanter i kodningen 
        //----------------------------------------------------- 

        const int months = 12; //Antal månader på ett år 

        const int a4Marginal = 3; //Antal cm i marginalen 

        const string appName = "Mitt program"; //Namnet på ditt program 
        const string programmer = "Ditt namn"; //Programmerarens namn 

        const int maxWidth = 80; //Max bredd för ett consolfönster 
        const int maxHeight = 25; //Max höjd för ett consolfönster 
    }

    public class ConstXmas
    {
        const int December = 12;
        const int XmasDate = 25;

        public void XmasCheck()
        {
            //Aktuell månad 
            int month = DateTime.Now.Month;
            //Aktuell dag
            int date = DateTime.Now.Day;

            //Läsbar kod där man förstår snabbt vad den gör 
            bool isDecember = month == December;
            bool hasNotPassed = date < XmasDate;

            if (isDecember && hasNotPassed)
            {
                Console.WriteLine("Snart är det jul");
            }
            else
            {
                Console.WriteLine("Julen är långt borta :(");
            }
        }
    }

    public class ConstStar
    {
        const int MaxPos = 8; //Maxvärde i X led 
        const int MinPos = 1; //Minvärde i X led 
        const int Direction = 1; //Steg per iteration 
        const int Amount = 25; // antal steg

        public void Run()
        {
            int posDirection = Direction; //Riktning för räknandet 
            int pos = 0; //Startposition 

            //Loop för att se hur räknaren fungerar 
            for (int count = 0; count < Amount; count++)
            {
                //Öka positionsräknaren 1 steg i aktuell riktning 
                pos += posDirection;

                //Kontrollera om den är utanför gränserna, ändra riktning isåfall 
                if (pos >= MaxPos)
                    posDirection = -Direction; // Gå vänster 
                if (pos <= MinPos)
                    posDirection = Direction; // Gå höger

                //Skapa utdatan 
                //String.Concat slår ihop flera strängar 
                string utdata = string.Concat(
                    pos.ToString(),
                    " ",
                    new string(' ', pos),
                    "*");

                Console.WriteLine(utdata);
            }
        }
    }
}