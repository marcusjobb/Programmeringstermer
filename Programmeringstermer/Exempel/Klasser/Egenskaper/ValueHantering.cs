namespace Programmeringstermer.Exempel.Klasser.Egenskaper.ValueHantering
{
    public class Rating
    {
        private int stars = 0;

        public int Stars
        {
            get { return stars; }
            set
            {
                // Om värdet är för lite sätt värdet till noll
                if (value < 0) stars = 0;
                // om värdet är för stor sätt värdet till 10
                else if (value > 10) stars = 10;
                // annars sätt värdet som angavs
                else stars = value;
            }
        }
    }
}