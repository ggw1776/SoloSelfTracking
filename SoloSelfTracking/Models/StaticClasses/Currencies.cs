namespace SoloSelfTracking.Models.StaticClasses
{
    public static class Currencies
    {
        public static readonly CurrencyItem ExceptionalEldrichIchor = new("Exceptional Eldritch Ichor");

        public static readonly CurrencyItem OrbOfDominance = new("Orb Of Dominance");
        public static readonly CurrencyItem AwakenersOrb = new("Awakener's Orb") { ExplicitModifiers = ["Destroys an item, applying its influence to another of the same item class", "The second item is reforged as a rare item with both influence types and new modifiers"] };
        public static readonly CurrencyItem ShapersExaltedOrb = new("Shaper's Exalted Orb");
        public static readonly CurrencyItem EldersExaltedOrb = new("Elder's Exalted Orb");
        public static readonly CurrencyItem OrbOfConflict = new("Orb Of Conflict");
        public static readonly CurrencyItem ExceptionalEldritchEmber = new("Exceptional Eldritch Ember");
        public static readonly CurrencyItem EldrichOrbOfAnnulment = new("Eldrich Orb Of Annulment");
        public static readonly CurrencyItem EldrichChaosOrb = new("Eldrich Chaos Orb");
        public static readonly CurrencyItem EldrichExaltedOrb = new("Eldrich Exalted Orb");
        public static readonly CurrencyItem OrbOfRememberance = new("Orb Of Rememberance");
        public static readonly CurrencyItem OrbOfIntention = new("Orb Of Intention");
        public static readonly CurrencyItem TemplarAstrolabe = new("Templar Astrolabe");
        public static readonly CurrencyItem ChaoticAstrolabe = new("Chaotic Astrolabe");
        public static readonly CurrencyItem DeceptiveAstrolabe = new("Deceptive Astrolabe");
        public static readonly CurrencyItem FruitingAstrolabe = new("Fruiting Astrolabe");
        public static readonly CurrencyItem FungalAstrolabe = new("Fungal Astrolabe");
        public static readonly CurrencyItem GraspingAstrolabe = new("Grasping Astrolabe");
        public static readonly CurrencyItem LightlessAstrolabe = new("Lightless Astrolabe");
        public static readonly CurrencyItem NamelessAstrolabe = new("Nameless Astrolabe");
        public static readonly CurrencyItem RunicAstrolabe = new("Runic Astrolabe");
        public static readonly CurrencyItem TimelessAstrolabe = new("Timeless Astrolabe");
    }
}
