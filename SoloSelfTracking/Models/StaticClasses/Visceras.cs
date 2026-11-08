using SoloSelfTracking.Enumerations;

namespace SoloSelfTracking.Models.StaticClasses
{
    public static class Visceras
    {
        public static readonly Viscera LesserWardensArm = new("Lesser Warden's Arm", EVisceraType.UpperLimb, "+35 to maximum life");
        public static readonly Viscera LesserBanditWarriorsHead = new("Lesser Bandit Warrior's Head", EVisceraType.Head, "Regenerate 0.83% of life per second");
        public static readonly Viscera LesserScorpionStinger = new("Lesser Scorpion Stinger", EVisceraType.Torso, "Poisons you inflict on non-poisoned enemies deal 59% increased damage");
        public static readonly Viscera UrsineFlesh = new("Ursine Flesh", EVisceraType.Torso, "30% reduced enemy stun threshold");
        public static readonly Viscera LesserPoachersLeg = new("Lesser Poacher's Leg", EVisceraType.LowerLimb, "-25 physical damage taken from hits by animals");
        public static readonly Viscera GreaterGolemicStone = new("Greater Golemic Stone", EVisceraType.Torso, "You cannot be stunned if you've been stunned or blocked a stunning hit in the past 2 seconds");
        public static readonly Viscera GreaterEldersHead = new("Greater Elder's Head", EVisceraType.Head, "Enemies chilled by your hits can be shattered as though frozen");
        public static readonly Viscera SirusHead = new("Sirus' Head", EVisceraType.Head, "Transfiguration of Mind");
        public static readonly Viscera GreaterSirusHead = new("Greater Sirus' Head", EVisceraType.Head, "Enemies you kill have a 9% chance to explode, dealing a tenth of their maximum life as damage of a random element");
        public static readonly Viscera MavensOrrery = new("Maven's Orrery", EVisceraType.Torso, "enemies within 3 meters are scorched");
        public static readonly Viscera AncestorsClub = new("Ancestor's Club", EVisceraType.UpperLimb, "Strike Skills which target additional Enemies can do so from 29% further away");
        public static readonly Viscera VoltaicSkull = new("VoltaicSkull", EVisceraType.Head, "21% of physical damage converted to lightning damage");
        public static readonly Viscera GreaterDistendedStomach = new("Greater Distended Stomach", EVisceraType.Torso, "Eat a soul when you consume the corpse of a rare monster");
        public static readonly Viscera ScholarsLeg = new("Scholar's Leg", EVisceraType.LowerLimb, "9% increased bonuses gained from equipped gloves");
    }
}
