namespace Programmeringstermer.Exempel.Klasser.Variabler.ByValOchByRef
{
    internal class ByValOchByRef_demo
    {
        public int MyValue { get; set; }

        public ByValOchByRef_demo(int value)
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

            ByValOchByRef_demo bvobrd = new ByValOchByRef_demo(5);
            ChangeValue(bvobrd);
            Console.WriteLine(bvobrd.MyValue);
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
        private static void ChangeValue(ByValOchByRef_demo bvobrd)
        {
            bvobrd.MyValue += 10;
        }
    }
    */
}