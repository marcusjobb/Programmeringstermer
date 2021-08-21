namespace Programmeringstermer.Exempel.Klasser.Metoder.Inparameter
{
    public class Inparameter_demo
    {
        public Inparameter_demo()
        {
            CallMe("maybe");
        }

        // "option" är en inparameter
        private void CallMe(string option)
        {
            Console.WriteLine("Hey, I just met you. And this is crazy.");
            Console.WriteLine("But here's my number. So call me, " + option + "?");
        }
    }
}