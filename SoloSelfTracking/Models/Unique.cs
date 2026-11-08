using SoloSelfTracking.Enumerations;
using System.Security.AccessControl;
using System.Xml.Linq;

namespace SoloSelfTracking.Models
{
    public class Unique : Item
    {
        public List<string> UniqueAffixes = [];

        public Unique(string name, EItemType baseType, string iconUrl = "")
        {
            Name = name;
            BaseType = baseType;
            Rarity = EItemRarity.Unique;

            if (iconUrl != string.Empty)
                IconUrl = "/img/item/unique/" + iconUrl;
        }
    }
}
