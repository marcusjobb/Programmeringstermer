namespace Programmeringstermer.Exempel.ArraysOchListor.ArrayDefinitioner
{
    public class Exempel
    {
        //Endimensionell array
        private string[] klasslista = new string[52];

        //Flerdimensionell array
        private int[,] luffarSchack = new int[3, 3];

        //Multidimensionell array
        private Cube[,,] hyperCube = new Cube[3, 3, 3];
    }

    internal class Cube
    {
        public float Width { get; set; }
        public float Height { get; set; }
        public float Depth { get; set; }
    }
}