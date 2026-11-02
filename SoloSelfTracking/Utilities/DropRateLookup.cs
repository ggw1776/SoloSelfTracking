using SoloSelfTracking.Models;
using SoloSelfTracking.Models.StaticClasses;
using System.Reflection;

namespace SoloSelfTracking.Utilities
{
    public static class DropRateLookup
    {
        public static float? Find(string bossName, string itemName)
        {
            var fields = typeof(BossDrops).GetFields(
                    BindingFlags.Public | BindingFlags.Static);

            foreach (var field in fields)
            {
                if (field.GetValue(null) is List<BossDrop> dropTable && string.Equals(field.Name, bossName.Replace(" ", ""), StringComparison.OrdinalIgnoreCase))
                {
                    return dropTable.SingleOrDefault(x => string.Equals(x.Drop.Name, itemName))?.DropRate;
                }
            }

            throw new KeyNotFoundException();
        }
    }
}
