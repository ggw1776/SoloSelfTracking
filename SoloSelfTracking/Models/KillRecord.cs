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
    }

    public class KillRecordDrop
    {
        public string Drop { get; set; }
        public int Count { get; set; } = 1;
    }
}
