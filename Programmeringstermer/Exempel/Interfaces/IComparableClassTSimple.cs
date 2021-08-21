namespace Programmeringstermer.Exempel.Interfaces.CollectionInterfaces
{
    internal class ComparableClassTSimple : IComparable<ComparableClassTSimple>
    {
        public int MyValue { get; set; }

        public int CompareTo(ComparableClassTSimple obj)
        {
            //Kolla om objektet är null
            if (obj == null) return 1;

            // Inbyggd metod
            return this.MyValue.CompareTo(obj.MyValue);
        }
    }
}