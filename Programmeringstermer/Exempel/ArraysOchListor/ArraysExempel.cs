namespace Programmeringstermer.Exempel.ArraysOchListor.ArraysExempel
{
    public class Handellista
    {
        public void Run()
        {
            int antalVaror = 3;
            double summa = 0;
            Varor[] handelLista = new Varor[antalVaror];
            handelLista[0] = new Varor
            {
                Namn = "Tröja",
                Pris = 107
            };
            handelLista[1] = new Varor
            {
                Namn = "Dataspel",
                Pris = 329
            };
            handelLista[2] = new Varor
            {
                Namn = "Bok",
                Pris = 150
            };
            for (int addera = 0; addera < handelLista.Length; addera++)
                summa += handelLista[addera].Pris;
            Console.WriteLine("Slutpris blir {0}", summa);
        }

        private class Varor
        {
            public string Namn { get; set; }
            public double Pris { get; set; }
        }
    }
}