using System;
using System.Collections.Generic;

namespace Programmeringstermer.Exempel.Klasser.Reflektion
{
    public class Reflektion
    {
        // Anropar metod och returnerar en lista
        internal static List<string> CallMethod(string callThis)
        {
            // Hämtar typen av klassen som
            // ska användas
            var classType = typeof(MyCoolClass);
            if (classType == null) return null;
            // Skapar en instans av klassen
            object classInstance = null;
            // Kollar om constructorn finns
            var constructorInfo = classType.GetConstructor(Type.EmptyTypes);
            // Kollar om den är tillgänglig
            if (constructorInfo?.IsPublic == true && !classType.IsAbstract)
                classInstance = Activator.CreateInstance(classType, null);//ej statisk/abstrakt
                                                                          // Kollar om metoden finns
            var method = classType.GetMethod(callThis);
            // Anropa metoden
            return method != null ? (List<string>)method.Invoke(classInstance, null) : null;
        }
    }

    // Klass skapad i en plugin
    // Som lästs in via DLL
    public class MyCoolClass
    {
        public List<string> GetBatmanCharacters()
        {
            return new List<string> { "Alfred", "Batman", "Robin" };
        }

        public List<string> GetSupermanCharacters()
        {
            return new List<string> { "Martha", "Johathan", "Clark", "Jor El", "Lara Lor-Van" };
        }
    }

    public class Test
    {
        public void Run()
        {
            var hero = "Superman";
            var method = "Get" + hero + "Characters";
            // Har Reflektionsklassen till att anropa
            // metoder i MyCoolClass
            var list = Reflektion.CallMethod(method);
            // Skriver ut listan
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}