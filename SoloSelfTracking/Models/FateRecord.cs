namespace SoloSelfTracking.Models
{
    public class FateRecord : KillRecord
    {
        public List<Fate> Fates { get; set; } = new();
    }
}
