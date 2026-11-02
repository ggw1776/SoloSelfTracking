namespace SoloSelfTracking.Utilities
{
    using SoloSelfTracking.Models;
    using System.Reflection;

    public static class ItemLookup<T> where T : Item
    {
        /// <summary>
        /// Example usage: ItemLookup<Unique>.Find("Mageblood", typeof(Unique))
        /// </summary>
        /// <param name="name"></param>
        /// <param name="sourceTypes"></param>
        /// <returns></returns>
        public static T? Find(string name, Type sourceType)
        {
            var fields = sourceType.GetFields(
                    BindingFlags.Public | BindingFlags.Static);

            foreach (var field in fields)
            {
                if (field.FieldType != typeof(T))
                    continue;

                if (field.GetValue(null) is T item &&
                    string.Equals(
                        item.Name,
                        name,
                        StringComparison.OrdinalIgnoreCase))
                {
                    return item;
                }
            }

            return null;
        }
    }
}
