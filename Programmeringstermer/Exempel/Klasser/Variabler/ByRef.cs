namespace Programmeringstermer.Exempel.Klasser.Variabler.ByRef
{
    public class ByRef_demo
    {
        public void CleanName(ref string name)
        {
            //Rensa bort mellanslag
            var newName = name.Trim();
            //Första bokstaven blir versal
            var names = newName.ToLower().Split(' ');
            name = "";
            foreach (var item in names)
            {
                // Första bokstaven blir versal
                var first = char.ToUpper(item[0]);
                // resten ändras inte
                var rest = item[1..];
                // Slå samman allt
                name += $"{first}{rest} ";
            }
            name = name.Trim();
        }
    }

    //internal class Program
    //{
    //    private static void Main()
    //    {
    //        var name = "lady gaga";
    //        var test = new TestByRef();
    //        test.CleanName(ref name);
    //        Console.WriteLine(name);
    //    }
    //}
}