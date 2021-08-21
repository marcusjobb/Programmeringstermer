namespace Programmeringstermer.Exempel.Klasser.Const
{
    public class ConstExempel
    {
        //-----------------------------------------------------
        //Exempel på hur man kan använda constanter i kodningen
        //-----------------------------------------------------

        private const int months = 12; //Antal månader på ett år

        private const int a4Marginal = 3; //Antal cm i marginalen

        private const string appName = "Mitt program"; //Namnet på ditt program
        private const string programmer = "Ditt namn"; //Programmerarens namn

        private const int maxWidth = 80; //Max bredd för ett consolfönster
        private const int maxHeight = 25; //Max höjd för ett consolfönster
    }

    public class ConstXmas
    {
        private const int December = 12;
        private const int XmasDate = 25;

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
        private const int MaxPos = 8; //Maxvärde i X led
        private const int MinPos = 1; //Minvärde i X led
        private const int Direction = 1; //Steg per iteration
        private const int Amount = 25; // antal steg

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