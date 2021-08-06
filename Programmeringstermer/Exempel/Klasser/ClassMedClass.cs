namespace Programmeringstermer.Exempel.ClassMedClass
{
    internal class ClassA
    {
        internal class AA
        {
            // Massor med kod
        }

        public ClassA()
        {
            var aa = new AA(); // Instansierar under-class
        }

        // Massor med kod
    }

    //internal void main()
    //{
    //    var a = new ClassA();
    //    var aa = new ClassA.AA();
    //}
}