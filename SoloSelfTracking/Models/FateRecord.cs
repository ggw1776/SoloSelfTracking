using SoloSelfTracking.Enumerations;

namespace SoloSelfTracking.Models
{
    public class FateRecord : KillRecord
    {
        public List<string> Fates { get; set; } = new();
        public List<EFateReward> Reward { get; set; } = new();
    }
}
