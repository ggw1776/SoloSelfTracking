using SoloSelfTracking.Models;
using SoloSelfTracking.Models.StaticClasses;

namespace SoloSelfTracking.Utilities
{
    /// <summary>
    /// this was such a mistake
    /// </summary>
    public static class ItemIndex
    {
        // private static readonly List<TypePair> Types = [new TypePair() { BaseType = typeof(Unique), SuperType = typeof(Uniques) }, new TypePair() { BaseType = typeof(CurrencyItem), SuperType = typeof(Currencies) }, new TypePair() { BaseType = typeof(DivinationCard), SuperType = typeof(DivinationCards) }, new TypePair() { BaseType = typeof(GemItem), SuperType = typeof(Gems) }, new TypePair() { BaseType = typeof(MiscItem), SuperType = typeof(MiscItems) }];

        public static Item? FindItem(string name)
        {
            Item result = null;

            result = ItemLookup<Unique>.Find(name, typeof(Uniques));
            if (result != null) return result;
            result = ItemLookup<CurrencyItem>.Find(name, typeof(Currencies));
            if (result != null) return result;
            result = ItemLookup<DivinationCard>.Find(name, typeof(DivinationCards));
            if (result != null) return result;
            result = ItemLookup<GemItem>.Find(name, typeof(Gems));
            if (result != null) return result;
            result = ItemLookup<MiscItem>.Find(name, typeof(MiscItems));
            if (result != null) return result;


            /*
             * I'm sure I'll figure this out one day
            var genericLookup = typeof(ItemLookup<>);

            foreach (var pair in Types)
            {
                var pairLookup = genericLookup.MakeGenericType(pair.BaseType);
                try
                {
                    dynamic constructedLookup = Activator.CreateInstance(pairLookup);
                    result = constructedLookup.Find(name, pair.SuperType);
                } catch { }

                if (result != null) break;
            }*/

            return result;
        }

        private class TypePair
        {
            public required Type BaseType;
            public required Type SuperType;
        }
    }
}
