using SoloSelfTracking.Enumerations;

namespace SoloSelfTracking.Models
{
    public class GemItem : Item
    {
        public int GemLevel { get; set; } = 1;
        public int Quality { get; set; }
        public bool IsSupportGem { get; set; }

        public GemItem(string name)
        {
            Name = name;
            Rarity = EItemRarity.Gem;
            IsSupportGem = true;
            
        }
    }
}
