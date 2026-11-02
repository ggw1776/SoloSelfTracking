using SoloSelfTracking.Enumerations;

namespace SoloSelfTracking.Models
{
    public class EquipmentItem : Item
    {
        public int Armour { get; set; }
        public int Evasion { get; set; }
        public int EnergyShield { get; set; }

        public EquipmentItem(string name, EItemType baseType, EItemRarity rarity)
        {
            Name = name;
            BaseType = baseType;
            Rarity = rarity;
            
        }
    }
}
