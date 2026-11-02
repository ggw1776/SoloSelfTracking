namespace SoloSelfTracking.Models
{
    public class BossDrop
    {
        public Item Drop { get; set; }
        public float DropRate;
        public bool IsMultiDrop { get; set; }

        public BossDrop(Item drop, float dropRate, bool isMultiDrop = false)
        {
            Drop = drop;
            DropRate = dropRate;
            IsMultiDrop = isMultiDrop;
        }
    }
}
