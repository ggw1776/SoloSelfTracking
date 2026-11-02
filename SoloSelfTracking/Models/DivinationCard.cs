using SoloSelfTracking.Enumerations;

namespace SoloSelfTracking.Models
{
    public class DivinationCard : Item
    {
        public DivinationCard(string name) 
        {
            Name = name;
            Rarity = EItemRarity.DivinationCard;
            
        }
    }
}
