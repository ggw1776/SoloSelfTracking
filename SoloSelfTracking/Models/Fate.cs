using SoloSelfTracking.Enumerations;

namespace SoloSelfTracking.Models
{
    public class Fate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Fate(string name)
        {
            Name = name;
        }
    }
}
