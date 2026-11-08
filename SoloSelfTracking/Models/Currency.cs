using SoloSelfTracking.Enumerations;

namespace SoloSelfTracking.Models
{
    public class CurrencyItem : Item
    {
        public CurrencyItem(string name, string description, string iconUrl = "")
        {
            Name = name;
            Rarity = EItemRarity.Currency;
            MaxStackSize = 20;
            ExplicitModifiers.Add(description);
            if (iconUrl != string.Empty)
                IconUrl = "/img/item/currency/" + iconUrl;
        }
    }
}
