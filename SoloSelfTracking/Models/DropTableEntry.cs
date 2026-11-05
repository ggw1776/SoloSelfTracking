namespace SoloSelfTracking.Models
{
    public class DropTableEntry
    {
        public Item Drop { get; set; }
        public float DropRate;
        public bool IsMultiDrop { get; set; }

        public DropTableEntry(Item drop, float dropRate, bool isMultiDrop = false)
        {
            Drop = drop;
            DropRate = dropRate;
            IsMultiDrop = isMultiDrop;
        }
    }
}
