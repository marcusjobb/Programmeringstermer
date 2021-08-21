namespace Programmeringstermer.Exempel.Interfaces.CollectionInterfaces
{
    internal class ComparableClass : IComparable
    {
        public int Value { get; set; }

        public int CompareTo(object obj)
        {
            //Kolla om objektet == null
            if (obj == null)
            {
                return 1; // Mer
            }
            //Kolla om objektet == ComparableClass
            else if (obj is ComparableClass)
            {
                //Typecasta
                ComparableClass compare = (ComparableClass)obj;

                //Evaluera
                if (this.Value < compare.Value)
                    return -1; // Mindre
                else if (this.Value > compare.Value)
                    return 1; // Mer
                else
                    return 0; //Lika
            }
            else
            {
                return 1; // Fel typ & blir automatiskt Mer
            }
        }
    }
}