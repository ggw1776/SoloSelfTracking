namespace SoloSelfTracking.Models.StaticClasses
{
    public static class Currencies
    {
        public static readonly CurrencyItem ExceptionalEldrichIchor = new("Exceptional Eldritch Ichor", "Adds an Exceptional Eater of Worlds implicit modifier to\r\na Body Armour, Boots, Gloves or Helmet\r\nThis replaces any existing implicit modifiers other than Searing Exarch implicit modifiers");

        public static readonly CurrencyItem OrbOfDominance = new("Orb Of Dominance", "Removes one Influenced Modifier from an item with at least two Influenced\r\nModifiers and upgrades another Influenced Modifier\r\nUpgrading a modifier of the highest tier transforms the\r\nmodifier into an Elevated Modifier\r\nAttempting to upgrade an Elevated Modifier rerolls its values\r\nCan be used on Body Armours, Boots, Gloves and Helmets");
        public static readonly CurrencyItem AwakenersOrb = new("Awakener's Orb", "Destroys an item, applying its influence to another of the same item class The second item is reforged as a rare item with both influence types and new modifiers");
        public static readonly CurrencyItem ShapersExaltedOrb = new("Shaper's Exalted Orb", "Adds Shaper influence and a new Shaper modifier to a rare item");
        public static readonly CurrencyItem EldersExaltedOrb = new("Elder's Exalted Orb", "Adds Elder influence and a new Elder modifier to a rare item");
        public static readonly CurrencyItem OrbOfConflict = new("Orb Of Conflict", "Unpredictably raise the strength of one Searing Exarch or Eater of Worlds modifier on an item and lower the strength of another\r\nLesser modifiers that have their strength lowered will be removed");
        public static readonly CurrencyItem ExceptionalEldritchEmber = new("Exceptional Eldritch Ember", "Adds an Exceptional Searing Exarch implicit modifier to\r\na Body Armour, Boots, Gloves or Helmet\r\nThis replaces any existing implicit modifiers other than Eater of Worlds implicit modifiers");
        public static readonly CurrencyItem EldrichOrbOfAnnulment = new("Eldrich Orb Of Annulment", "If The Searing Exarch is dominant, remove a prefix modifier\r\nIf The Eater of Worlds is dominant, remove a suffix modifier");
        public static readonly CurrencyItem EldrichChaosOrb = new("Eldrich Chaos Orb", "If The Searing Exarch is dominant, reroll prefix modifiers\r\nIf The Eater of Worlds is dominant, reroll suffix modifiers");
        public static readonly CurrencyItem EldrichExaltedOrb = new("Eldrich Exalted Orb", "If The Searing Exarch is dominant, add a prefix modifier\r\nIf The Eater of Worlds is dominant, add a suffix modifier");
        public static readonly CurrencyItem OrbOfRememberance = new("Orb Of Rememberance", "Randomises the number of Memory Strands on a normal equipment item");
        public static readonly CurrencyItem OrbOfIntention = new("Orb Of Intention", "Modifies a Memory Influenced Map, causing items found to\r\nhave more Memory Strands, but fewer items drop");
        public static readonly CurrencyItem TemplarAstrolabe = new("Templar Astrolabe", "Adds a Shaped Region to a quadrant of the Atlas");
        public static readonly CurrencyItem ChaoticAstrolabe = new("Chaotic Astrolabe", "Adds a Shaped Region containing Ultimatum encounters to a quadrant of the Atlas");
        public static readonly CurrencyItem DeceptiveAstrolabe = new("Deceptive Astrolabe", "Adds a Shaped Region containing Mirrors of Delirium to a quadrant of the Atlas");
        public static readonly CurrencyItem FruitingAstrolabe = new("Fruiting Astrolabe", "Adds a Shaped Region containing the Sacred Grove to a quadrant of the Atlas");
        public static readonly CurrencyItem FungalAstrolabe = new("Fungal Astrolabe", "Adds a Shaped Region containing Blight encounters to a quadrant of the Atlas");
        public static readonly CurrencyItem GraspingAstrolabe = new("Grasping Astrolabe", "Adds a Shaped Region containing Breaches to a quadrant of the Atlas");
        public static readonly CurrencyItem LightlessAstrolabe = new("Lightless Astrolabe", "Adds a Shaped Region containing Abysses to a quadrant of the Atlas");
        public static readonly CurrencyItem NamelessAstrolabe = new("Nameless Astrolabe", "Adds a Shaped Region containing Ritual Altars to a quadrant of the Atlas");
        public static readonly CurrencyItem RunicAstrolabe = new("Runic Astrolabe", "Adds a Shaped Region containing Expedition encounters to a quadrant of the Atlas");
        public static readonly CurrencyItem TimelessAstrolabe = new("Timeless Astrolabe", "Adds a Shaped Region containing Legion encounters to a quadrant of the Atlas");

        public static readonly CurrencyItem GrandEldritchEmber = new("Grand Eldritch Ember", "Adds a Grand Searing Exarch implicit modifier to\r\na Body Armour, Boots, Gloves or Helmet\r\nThis replaces any existing implicit modifiers other than Eater of Worlds implicit modifiers");
        public static readonly CurrencyItem GreaterEldritchEmber = new("Greater Eldritch Ember", "Adds a Greater Searing Exarch implicit modifier to\r\na Body Armour, Boots, Gloves or Helmet\r\nThis replaces any existing implicit modifiers other than Eater of Worlds implicit modifiers");
        public static readonly CurrencyItem GreaterEldritchIchor = new("Greater Eldritch Ichor", "Adds a Greater Eater of Worlds implicit modifier to\r\na Body Armour, Boots, Gloves or Helmet\r\nThis replaces any existing implicit modifiers other than Searing Exarch implicit modifiers");
        public static readonly CurrencyItem GrandEldritchIchor = new("Grand Eldritch Ichor", "Adds a Grand Eater of Worlds implicit modifier to\r\na Body Armour, Boots, Gloves or Helmet\r\nThis replaces any existing implicit modifiers other than Searing Exarch implicit modifiers");
        public static readonly CurrencyItem VeiledExaltedOrb = new("Veiled Exalted Orb", "Removes a random modifier and adds a random Veiled modifier to a rare item");
        public static readonly CurrencyItem AllflameEmberOfKulemak = new("Allflame Ember Of Kulemak", "Substitutes Monster Packs in Area\r\nPack Leaders are random Syndicate Members which\r\ncan have random Syndicate Gear equipped\r\nPack Monsters revive after Final Map Boss has been slain");
        public static readonly CurrencyItem CorruptedCatalyst = new("Tainted Catalyst", "Applies a random quality type and amount of quality to a Corrupted ring, amulet or belt\r\nReplaces other quality types");

        public static readonly CurrencyItem ArmourersScrap = new("Armourer's Scrap", "Improves the quality of an armour", "armorscrap.png" );
        public static readonly CurrencyItem BlacksmithsWhetstone = new("Blacksmith's Whetstone", "Improves the quality of a weapon", "Blacksmith's_Whetstone_inventory_icon.png");
        public static readonly CurrencyItem OrbOfAugmentation = new("Orb Of Augmentation", "Augments a magic item with a new random modifier", "Orb_of_Augmentation_inventory_icon.png");
        public static readonly CurrencyItem OrbOfTransmutation = new("Orb Of Transmutation", "Upgrades a normal item to a magic item", "Orb_of_Transmutation_inventory_icon.png");
        public static readonly CurrencyItem GlassblowersBauble = new("Glassblower's Bauble", "Improves the quality of a flask or tincture", "Glassblower's_Bauble_inventory_icon.png");
        public static readonly CurrencyItem OrbOfAlchemy = new("Orb Of Alchemy", "Upgrades a normal item to a rare item", "Orb_of_Alchemy_inventory_icon.png");
        public static readonly CurrencyItem OrbOfAlteration = new("Orb Of Alteration", "Reforges a magic item with new random modifiers", "Orb_of_Alteration_inventory_icon.png");
        public static readonly CurrencyItem OrbOfChance = new("Orb Of Chance", "Upgrades a normal item to a random rarity", "Orb_of_Chance_inventory_icon.png");
        public static readonly CurrencyItem OrbOfRegret = new("Orb Of Regret", "Grants a passive skill refund point", "Orb_of_Regret_inventory_icon.png");
        public static readonly CurrencyItem JewellersOrb = new("Jeweller's Orb", "Reforges the number of sockets on an item", "Jeweller's_Orb_inventory_icon.png");
        public static readonly CurrencyItem OrbOfFusing = new("Orb Of Fusing", "Reforges the links between sockets on an item", "Orb_of_Fusing_inventory_icon.png");
        public static readonly CurrencyItem ChaosOrb = new("Chaos Orb", "Reforges a rare item with new random modifiers", "Chaos_Orb_inventory_icon.png");
        public static readonly CurrencyItem GemcuttersPrism = new("Gemcutter's Prism", "Improves the quality of a gem", "Gemcutter's_Prism_inventory_icon.png");
        public static readonly CurrencyItem OrbOfScouring = new("Orb Of Scouring", "Removes all modifiers from an item", "Orb_of_Scouring_inventory_icon.png");
        public static readonly CurrencyItem RegalOrb = new("Regal Orb", "Upgrades a magic item to a rare item", "Regal_Orb_inventory_icon.png");
        public static readonly CurrencyItem VaalOrb = new("Vaal Orb", "Corrupts an item, modifying it unpredictably", "Vaal_Orb_inventory_icon.png");
        public static readonly CurrencyItem ChromaticOrb = new("Chromatic Orb", "Reforges the colour of sockets on an item", "Chromatic_Orb_inventory_icon.png");
        public static readonly CurrencyItem OrbOfBinding = new("Orb Of Binding", "Upgrades a normal item to a rare item with up to four linked sockets", "Orb_of_Binding_inventory_icon.png");
        public static readonly CurrencyItem AncientOrb = new("Ancient Orb", "Reforges a unique equipment as another of the same item class", "Ancient_Orb.png" );
        public static readonly CurrencyItem BlessedOrb = new("Blessed Orb", "Randomises the values of the implicit modifiers of an item", "Blessed_Orb_inventory_icon.png");
        public static readonly CurrencyItem DivineOrb = new("Divine Orb", "Randomises the values of the random modifiers on an item", "Divine_Orb_inventory_icon.png");
        public static readonly CurrencyItem ExaltedOrb = new("Exalted Orb", "Augments a rare item with a new random modifier", "Exalted_Orb_inventory_icon.png");
        public static readonly CurrencyItem MirrorOfKalandra = new("Mirror Of Kalandra", "Creates a mirrored copy of an item", "Mirror_of_Kalandra_inventory_icon.png");
        public static readonly CurrencyItem OrbOfAnnulment = new("Orb Of Annulment", "Removes a random modifier from an item", "Orb_of_Annulment_inventory_icon.png");
        public static readonly CurrencyItem SacredOrb = new("Sacred Orb", "Randomises the numeric values of base defences on an armour", "Sacred_Orb_inventory_icon.png");
        public static readonly CurrencyItem EnkindlingOrb = new("Enkindling Orb", "Adds an enchantment to a utility flask that will improve it but prevent it from gaining charges during its effect. Replaces any existing enchantment", "Enkindling_Orb_inventory_icon.png");
        public static readonly CurrencyItem InstillingOrb = new("Instilling Orb", "Adds an enchantment to a utility flask that will cause it to be used when certain conditions are met. Replaces any existing enchantment", "Instilling_Orb_inventory_icon.png");
        public static readonly CurrencyItem FracturingOrb = new("Fracturing Orb", "Fracture a random modifier on a rare item with at least 4 modifiers, locking it in place", "Fracturing_Orb_inventory_icon.png");
        public static readonly CurrencyItem OrbOfUnmaking = new("Orb Of Unmaking", "Grants an atlas passive skill refund point", "Orb_of_Unmaking_inventory_icon.png");
        public static readonly CurrencyItem VolatileVaalOrb = new("Volatile Vaal Orb", "Unpredictably either randomises the values of random modifiers on a unique equipment and corrupts it, or destroys it", "Volatile_Vaal_Orb_inventory_icon.png");

        public static readonly CurrencyItem TemperingOrb = new("Tempering Orb", "Adds or replaces an enchantment on a weapon\r\nThis may reforge the weapon's sockets", "Tempering_Orb_inventory_icon.png");
        public static readonly CurrencyItem TailoringOrb = new("Tailoring Orb", "Adds or replaces an enchantment on a body armour\r\nThis may reforge the body armour's sockets", "Tailoring_Orb_inventory_icon.png");

        public static readonly CurrencyItem ClearOil = new("Clear Oil", "", "Clear_Oil_inventory_icon.png");
        public static readonly CurrencyItem SepiaOil = new("Sepia Oil", "", "Sepia_Oil_inventory_icon.png");
        public static readonly CurrencyItem AmberOil = new("Amber Oil", "", "Amber_Oil_inventory_icon.png");
        public static readonly CurrencyItem VerdantOil = new("Verdant Oil", "", "Verdant_Oil_inventory_icon.png");
        public static readonly CurrencyItem TealOil = new("Teal Oil", "", "Teal_Oil_inventory_icon.png");
        public static readonly CurrencyItem AzureOil = new("Azure Oil", "", "Azure_Oil_inventory_icon.png");
        public static readonly CurrencyItem IndigoOil = new("Indigo Oil", "", "Indigo_Oil_inventory_icon.png");
        public static readonly CurrencyItem VioletOil = new("Violet Oil", "", "Violet_Oil_inventory_icon.png");
        public static readonly CurrencyItem CrimsonOil = new("Crimson Oil", "", "Crimson_Oil_inventory_icon.png");
        public static readonly CurrencyItem BlackOil = new("Black Oil", "", "Black_Oil_inventory_icon.png");
        public static readonly CurrencyItem OpalescentOil = new("Opalescent Oil", "", "Opalescent_Oil_inventory_icon.png");
        public static readonly CurrencyItem SilverOil = new("Silver Oil", "", "Silver_Oil_inventory_icon.png");
        public static readonly CurrencyItem GoldenOil = new("Golden Oil", "", "Golden_Oil_inventory_icon.png");
        public static readonly CurrencyItem TaintedOil = new("Tainted Oil", "", "Tainted_Oil_inventory_icon.png");
        public static readonly CurrencyItem ReflectiveOil = new("Reflective Oil", "", "78px-Reflective_Oil_inventory_icon.png");
        public static readonly CurrencyItem PrismaticOil = new("Prismatic Oil", "", "Prismatic_Oil_inventory_icon.png");
    }
}
