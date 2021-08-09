using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmeringstermer.Exempel.Klasser.BaseThis

{
    class MotherClass
    {
        public virtual string Name { get; set; } = "MotherClass";
    }
    class ChildClass : MotherClass
    {
        public override string Name{ get => this.Name; set => this.Name = value; }
        public string Mother{ get => base.Name; set => base.Name = value; }
        public ChildClass()
        {
            this.Name = "ChildClass";
        }
    }
    public class Test
    {
        public void Run()
        {
            var child = new ChildClass();
            Console.WriteLine("Mother name  : " + child.Mother);
            Console.WriteLine("Child name   : " + child.Name);
        }
    }
}