using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmeringstermer.Exempel.Klasser.Polymorphism
{
class MotherClass
{
    public virtual string Name { get; set; } = "MotherClass";
}
class ChildClass : MotherClass
{
    public override string Name { get; set; } = "ChildClass";
}
class UnrulyChildClass : MotherClass
{
    public new string Name { get; set; } = "Unruly ChildClass";
}

public class Test
{
    public void Run()
    {
        TestClasses();
        Console.WriteLine();
        TestClasses_polymorphism();
    }

    private static void TestClasses()
    {
        MotherClass mother = new MotherClass();
        MotherClass child = new ChildClass();
        MotherClass uchild = new UnrulyChildClass();
        Console.WriteLine("Mother name  : " + mother.Name);
        Console.WriteLine("Child name   : " + child.Name);
        Console.WriteLine("Unruly child : " + uchild.Name);
        // Mother name  : MotherClass
        // Child name   : ChildClass
        // Unruly child : Unruly ChildClass
    }

    private static void TestClasses_polymorphism()
    {
        MotherClass mother = new MotherClass();
        ChildClass child = new ChildClass();
        UnrulyChildClass uchild = new UnrulyChildClass();
        Console.WriteLine("Mother name  : " + mother.Name);
        Console.WriteLine("Child name   : " + child.Name);
        Console.WriteLine("Unruly child : " + uchild.Name);
        // Mother name  : MotherClass
        // Child name   : ChildClass
        // Saknar Override, Moderklassens
        // metod anropas
        // Unruly child : MotherClass
    }
}
}