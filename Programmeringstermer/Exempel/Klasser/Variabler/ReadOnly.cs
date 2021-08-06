namespace Programmeringstermer.Exempel.Klasser.Variabler.ReadOnly
{
    internal class UserName
    {
        public readonly string Name;

        public UserName(string name)
        {
            Name = name;
        }
    }

    //public void main()
    //{
    //    var user = new UserName("Meliodas");
    //    user.Name = "Estarossa"; // error
    //}
}