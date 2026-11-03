using Microsoft.EntityFrameworkCore;

namespace SoloSelfTracking.Models
{
    public class IncursionRecord : KillRecord
    {
        public int AreaLevel { get; set; }
        public List<TempleRoom> OpenRooms { get; set; } = new();
        public List<TempleRoom> ObstructedRooms { get; set; } = new();

        public void ApplyKillRecord(KillRecord record)
        {
            Id = record.Id;
            Date = record.Date;
            Boss = record.Boss;
            Drops = record.Drops;
            Deaths = record.Deaths;
            ElapsedTime = record.ElapsedTime;

            MapQuantity = record.MapQuantity;
            MapRarity = record.MapRarity;
            MapMonsterPackSize = record.MapMonsterPackSize;
            MapScarabs = record.MapScarabs;
            MapMaps = record.MapMaps;
            MapCurrency = record.MapCurrency;
            MapDivCards = record.MapDivCards;
        }

        public class TempleRoom
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public int Tier { get; set; } = 0;
        }
    }
}
