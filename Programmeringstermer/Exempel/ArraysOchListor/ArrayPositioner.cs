namespace Programmeringstermer.Exempel.ArraysOchListor.ArrayPositioner
{
    public class ArrayPositionering
    {
        public void Run()
        {
            string[] nameList =
            {
                "Jake Sully","Dr. Grace Augustine", "Neytiri",
                "Colonel Miles Quaritch","Trudy Chacon"
            };

            int firstName = 0; // Alltid 0
            int middleName = nameList.Length / 2;
            int lastName = nameList.Length - 1;
            int amountOfNames = nameList.Length;

            Console.WriteLine("Start :{0} {1}", firstName, nameList[firstName]);
            Console.WriteLine("Mitten :{0} {1}", middleName, nameList[middleName]);
            Console.WriteLine("Sista :{0} {1}", lastName, nameList[lastName]);
            Console.WriteLine("Antal namn i listan:{0}", amountOfNames);

            //Resultatet blir:
            //Start :0 Jake Sully
            //Mitten :2 Neytiri
            //Sista :4 Trudy Chacon
            //Antal namn i listan:5
        }
    }
}