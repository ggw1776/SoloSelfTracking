using SoloSelfTracking.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SoloSelfTracking.Utilities
{
    public static class KillRecordUtilities<T> where T : KillRecord
    {
        public static void ApplyKillRecord(T record, KillRecord toApply)
        {

            record.Id = toApply.Id;
            record.Date = toApply.Date;
            record.Boss = toApply.Boss;
            record.Drops = toApply.Drops;
            record.Deaths = toApply.Deaths;
            record.ElapsedTime = toApply.ElapsedTime;

            record.MapQuantity = toApply.MapQuantity;
            record.MapRarity = toApply.MapRarity;
            record.MapMonsterPackSize = toApply.MapMonsterPackSize;
            record.MapScarabs = toApply.MapScarabs;
            record.MapMaps = toApply.MapMaps;
            record.MapCurrency = toApply.MapCurrency;
            record.MapDivCards = toApply.MapDivCards;
        }
    }
}
