using SoloSelfTracking.Enumerations;

namespace SoloSelfTracking.Models
{
    public class Viscera : Item
    {
        public EVisceraType VisceraType { get; set; }

        public Viscera(string name,  EVisceraType type, string affix)
        {
            Name = name;
            VisceraType = type;
            ExplicitModifiers.Add(affix);
        }
    }
}
