namespace Programmeringstermer.Exempel.Interfaces.CollectionInterfaces
{
    internal class ComparableClassT : IComparable<ComparableClassT>
    {
        public int MyValue { get; set; }

        public int CompareTo(ComparableClassT obj)
        {
            //Kolla om objektet är null
            if (obj == null) return 1;
            //Evaluera
            if (this.MyValue < obj.MyValue)
                return -1; // Mindre
            else if (this.MyValue > obj.MyValue)
                return 1; // Mer
            else
                return 0; //Lika
        }
    }
}