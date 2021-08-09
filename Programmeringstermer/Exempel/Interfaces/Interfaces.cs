using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmeringstermer.Exempel.Interfaces
{
    public interface IHairy
    {
        bool IsHairy { get; set; }
    }

    public interface IBoop
    {
        bool CanBoop { get; set; }
    }
    public interface IBark
    {
        bool CanBark { get; set; }
    }
    public interface IGrowl
    {
        bool CanGrowl { get; set; }
    }
    public interface ITearArms
    {
        bool CanTearArms { get; set; }
    }

    public class GoldenRetriever : IBark, IBoop, IHairy
    {
        public bool IsHairy { get; set; }
        public bool CanBoop { get; set; }
        public bool CanBark { get; set; }
    }

    public class Poodle : IBark, IGrowl, IHairy, IBoop
    {
        public bool CanGrowl { get; set; }
        public bool IsHairy { get; set; }
        public bool CanBark { get; set; }
        public bool CanBoop { get; set; }
    }
    public class Chewbacca : IHairy, IGrowl, ITearArms
    {
        public bool IsHairy { get; set; }
        public bool CanGrowl { get; set; }
        public bool CanTearArms { get; set; }
    }
    public class MetalRocker : IHairy, IGrowl
    {
        public bool IsHairy { get; set; }
        public bool CanGrowl { get; set; }
    }
}
