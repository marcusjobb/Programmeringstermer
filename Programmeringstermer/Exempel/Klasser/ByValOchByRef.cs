namespace Programmeringstermer.Exempel.Klasser.ByValOchByRef
{
    internal class MinClass
    {
        public int MyValue { get; set; }

        public MinClass(int value)
        {
            this.MyValue = value;
        }
    }

    /*
    public class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            ChangeValue(x);
            Console.WriteLine(x);

            string s = "Hej";
            ChangeValue(s);
            Console.WriteLine(s);

            MinClass mc = new MinClass(5);
            ChangeValue(mc);
            Console.WriteLine(mc.MyValue);
        }

        //int är ByValue så x kommer aldrig att ändras i metoden som anropade
        private static void ChangeValue(int x)
        {
            x += 5;
        }
        //string är ByValue så s kommer aldrig att ändras i metoden som anropade
        private static void ChangeValue(string s)
        {
            s += "!!!";
        }
        //Classer är ByRef så valuet i dem kan ändras i metoden
        private static void ChangeValue(MinClass mc)
        {
            mc.MyValue += 10;
        }
    }
    */
}