using SoloSelfTracking.Enumerations;
using System.Security.AccessControl;
using System.Xml.Linq;

namespace SoloSelfTracking.Models
{
    public class Unique : Item
    {
        public List<string> UniqueAffixes = [];

        public Unique(string name, EItemType baseType)
        {
            Name = name;
            BaseType = baseType;
            Rarity = EItemRarity.Unique;
            
        }
    }
}
