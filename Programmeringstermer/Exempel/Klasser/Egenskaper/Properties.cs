namespace Programmeringstermer.Exempel.Klasser.Egenskaper.Properties
{
    internal class Person_old_fashion
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    internal class Person_Autoproperty
    {
        public string Name { get; set; }
    }

    internal class Person_Expression
    {
        private string name;

        public string Name
        {
            get => name;
            set => name = value;
        }
    }
}