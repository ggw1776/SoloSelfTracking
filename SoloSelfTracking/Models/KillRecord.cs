namespace SoloSelfTracking.Models
{
    public class KillRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Boss { get; set; } = string.Empty;
        public List<KillRecordDrop> Drops { get; set; } = new();
        public int Deaths { get; set; } = 0;
        public TimeSpan ElapsedTime { get; set; }
        public int MapQuantity { get; set; }
        public int MapRarity { get; set; }
        public int MapMonsterPackSize { get; set; }
        public int MapScarabs { get; set; }
        public int MapMaps { get; set; }
        public int MapCurrency { get; set; }
        public int MapDivCards { get; set; }
        public int MapAtlasDrops { get; set; }
        public string Activity { get; set; } = string.Empty;
        public int Wings { get; set; }


        public bool IsMapStatsSet()
        {
            return MapQuantity > 0 || MapRarity > 0 || MapMonsterPackSize > 0 || MapScarabs > 0 || MapMaps > 0 || MapCurrency > 0 || MapDivCards > 0 || MapAtlasDrops > 0;
        }
    }

    public class KillRecordDrop
    {
        public string Drop { get; set; }
        public int Count { get; set; } = 1;
    }
}
