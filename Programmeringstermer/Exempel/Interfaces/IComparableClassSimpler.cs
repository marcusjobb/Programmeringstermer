namespace Programmeringstermer.Exempel.Interfaces.CollectionInterfaces
{
    internal class ComparableClassSimpler : IComparable
    {
        public int Value { get; set; }

        public int CompareTo(object obj)
        {
            //Kolla om objektet är null
            if (obj == null)
            {
                return 1;
            }
            //Kolla om objektet == ComparableClassSimpler
            else if (obj is ComparableClassSimpler)
            {
                //Typecasta objektet
                ComparableClassSimpler compare = (ComparableClassSimpler)obj;

                // Inbyggd metod
                return this.Value.CompareTo(compare.Value);
            }
            else
            {
                return 1;
            }
        }
    }
}