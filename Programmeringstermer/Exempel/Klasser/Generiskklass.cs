namespace Programmeringstermer.Exempel.Klasser.Generiskklass
{
    internal class Filehandler<T>
    {
        public void SaveFile(string filename, T data)
        {
            File.WriteAllText(filename, data.ToString());
        }

        public T LoadFile(string filename)
        {
            var data = default(T);
            if (File.Exists(filename))
            {
                var file = File.ReadAllText(filename);
                data = (T)Convert.ChangeType(file, typeof(T));
            }
            return data;
        }
    }

    //internal static class Program
    //{
    //    private static void Main(string[] args)
    //    {
    //        var demo = new Filehandler<int>();
    //        demo.SaveFile("test.txt", 5);
    //        Console.WriteLine(demo.LoadFile("test.txt"));
    //        var demo2 = new Filehandler<double>();
    //        demo2.SaveFile("test2.txt", 5.5);
    //        Console.WriteLine(demo.LoadFile("test2.txt"));
    //    }
    //}
}