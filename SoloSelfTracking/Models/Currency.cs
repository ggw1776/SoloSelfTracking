using SoloSelfTracking.Enumerations;

namespace SoloSelfTracking.Models
{
    public class CurrencyItem : Item
    {
        public CurrencyItem(string name)
        {
            Name = name;
            Rarity = EItemRarity.Currency;
            MaxStackSize = 20;
            
        }
    }
}
