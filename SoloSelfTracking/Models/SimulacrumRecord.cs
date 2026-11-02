namespace SoloSelfTracking.Models
{
    public class SimulacrumWave
    {
        public int WaveNumber { get; set; }
        public bool IsBossWave { get { return IsOmniphobiaWave || IsKosisWave; } }
        public List<SimulacrumUniqueDrop> UniqueDrops { get; set; } = new();
        public bool IsOmniphobiaWave { get; set; }
        public bool IsKosisWave { get; set; }
    }

    public class SimulacrumUniqueDrop
    {
        public string JewelName { get; set; } = string.Empty;
        public List<string> Options { get; set; } = new();
        public int Wave { get; set; }
    }

    public class SimulacrumRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Arena { get; set; } = string.Empty;
        public List<SimulacrumWave> Waves { get; set; } = new();
        public int Deaths { get; set; } = 0;
        public TimeSpan ElapsedTime { get; set; }

        public IEnumerable<SimulacrumUniqueDrop> UniqueDrops =>
            Waves.SelectMany(wave => wave.UniqueDrops);
    }
}
