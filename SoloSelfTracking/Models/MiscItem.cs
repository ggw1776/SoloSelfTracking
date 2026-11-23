namespace SoloSelfTracking.Models
{
    public class MiscItem : Item
    {
        public MiscItem(string name, string iconUrl = "")
        {
            Name = name;

            if (iconUrl != string.Empty)
                IconUrl = "/img/item/misc/" + iconUrl;
        }
    }
}
