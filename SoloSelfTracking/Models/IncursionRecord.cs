using Microsoft.EntityFrameworkCore;

namespace SoloSelfTracking.Models
{
    public class IncursionRecord : KillRecord
    {
        public int AreaLevel { get; set; }
        public List<TempleRoom> OpenRooms { get; set; } = new();
        public List<TempleRoom> ObstructedRooms { get; set; } = new();

        public class TempleRoom
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public int Tier { get; set; } = 0;
        }
    }
}
