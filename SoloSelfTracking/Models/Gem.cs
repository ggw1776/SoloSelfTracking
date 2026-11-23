using SoloSelfTracking.Enumerations;

namespace SoloSelfTracking.Models
{
    public class GemItem : Item
    {
        public int GemLevel { get; set; } = 1;
        public int Quality { get; set; }
        public bool IsSupportGem { get; set; }

        public GemItem(string name, string iconUrl = "")
        {
            Name = name;
            Rarity = EItemRarity.Gem;
            IsSupportGem = true;

            if (iconUrl != string.Empty)
                IconUrl = "/img/item/gem/" + iconUrl;
        }
    }
}
