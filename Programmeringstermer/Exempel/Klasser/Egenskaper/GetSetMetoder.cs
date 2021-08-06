namespace Programmeringstermer.Exempel.Klasser.Egenskaper.GetSetMetoder
{
    //public void main()
    //{
    //Glasskiosk gk = new Glasskiosk();
    //gk.SetPucko(10);
    //Console.WriteLine("Det finns {0} puckon på lager",gk.GetPucko());

    //Här använder vi två metoder för att läsa av och sätta ett värde
    //}

    public class Glasskiosk
    {
        private int pucko = 0;

        public int GetPucko()
        {
            return pucko;
        }

        public void SetPucko(int tal)
        {
            pucko = tal;
        }
    }
}