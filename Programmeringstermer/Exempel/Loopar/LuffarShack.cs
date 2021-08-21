namespace Programmeringstermer.Exempel.Loopar.NestedLoops
{
    public class LuffarShack
    {
        public void DrawMap()
        {
            //Skapa en karta för luffarschack
            //OBS! Detta är inte ett färdigt spel
            //Den får du skriva själv :)
            int[,] luffarShack = new int[3, 3];
            for (int posY = 0; posY < 3; posY++)
            {
                for (int posX = 0; posX < 3; posX++)
                {
                    switch (luffarShack[posY, posX])
                    {
                        case 1: Console.Write("O"); break;
                        case 2: Console.Write("X"); break;
                        default: Console.Write(" "); break;
                    }
                    if (posX < 2) Console.Write("|");
                }
                Console.WriteLine();
                if (posY < 2) Console.WriteLine("------");
            }
        }
    }
}