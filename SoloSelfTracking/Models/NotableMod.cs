namespace SoloSelfTracking.Models
{
    public class NotableMod
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public NotableMod(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
