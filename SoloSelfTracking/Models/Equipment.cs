using SoloSelfTracking.Enumerations;

namespace SoloSelfTracking.Models
{
    public class EquipmentItem : Item
    {
        public int Armour { get; set; }
        public int Evasion { get; set; }
        public int EnergyShield { get; set; }

        public EquipmentItem(string name, EItemType baseType, EItemRarity rarity = EItemRarity.Normal)
        {
            Name = name;
            BaseType = baseType;
            Rarity = rarity;
            SetInventoryIcon();
        }

        private void SetInventoryIcon()
        {
            switch (BaseType)
            {
                case EItemType.ThiefsTrinket:
                    IconUrl = "Thief's_Trinket_inventory_icon.png";
                    break;
                case EItemType.PsychoticAxe:
                    IconUrl = "Psychotic_Axe_inventory_icon.png";
                    break;
                case EItemType.ApexCleaver:
                    IconUrl = "Apex_Cleaver_inventory_icon.png";
                    break;
                case EItemType.VoidFangs:
                    IconUrl = "Void_Fangs_inventory_icon.png";
                    break;
                case EItemType.PneumaticDagger:
                    IconUrl = "Pneumatic_Dagger_inventory_icon.png";
                    break;
                case EItemType.BoomMace:
                    IconUrl = "Boom_Mace_inventory_icon.png";
                    break;
                case EItemType.StabilisingSceptre:
                    IconUrl = "Stabilising_Sceptre_inventory_icon.png";
                    break;
                case EItemType.ImpactForcePropagator:
                    IconUrl = "Impact_Force_Propagator_inventory_icon.png";
                    break;
                case EItemType.EventualityRod:
                    IconUrl = "Eventuality_Rod_inventory_icon.png";
                    break;
                case EItemType.InfernalBlade:
                    IconUrl = "Infernal_Blade_inventory_icon.png";
                    break;
                case EItemType.SolarineBow:
                    IconUrl = "Solarine_Bow_inventory_icon.png";
                    break;
                case EItemType.BatteryStaff:
                    IconUrl = "Battery_Staff_inventory_icon.png";
                    break;
                case EItemType.BanishingBlade:
                    IconUrl = "Banishing_Blade_inventory_icon.png";
                    break;
                case EItemType.AccumulatorWand:
                    IconUrl = "Accumulator_Wand_inventory_icon.png";
                    break;
                case EItemType.HeatattunedTowerShield:
                    IconUrl = "Heat-attuned_Tower_Shield_inventory_icon.png";
                    break;
                case EItemType.TransferattunedSpiritShield:
                    IconUrl = "Transfer-attuned_Spirit_Shield_inventory_icon.png";
                    break;
                case EItemType.MechanicalBelt:
                    IconUrl = "Mechalarm_Belt_inventory_icon.png";
                    break;
                case EItemType.FocusedAmulet:
                    IconUrl = "78px-Focused_Amulet_inventory_icon.png";
                    break;
                case EItemType.SimplexAmulet:
                    IconUrl = "Simplex_Amulet_inventory_icon.png";
                    break;
                case EItemType.CogworkRing:
                    IconUrl = "Cogwork_Ring_inventory_icon.png";
                    break;
                case EItemType.CompositeRing:
                    IconUrl = "78px-Composite_Ring_inventory_icon.png";
                    break;
                case EItemType.HelicalRing:
                    IconUrl = "78px-Helical_Ring_inventory_icon.png";
                    break;
                case EItemType.GeodesicRing:
                    IconUrl = "Geodesic_Ring_inventory_icon.png";
                    break;
                case EItemType.ManifoldRing:
                    IconUrl = "78px-Manifold_Ring_inventory_icon.png";
                    break;
                case EItemType.RatchetingRing:
                    IconUrl = "78px-Ratcheting_Ring_inventory_icon.png";
                    break;
                case EItemType.ColdattunedBuckler:
                    IconUrl = "Cold-attuned_Buckler_inventory_icon.png";
                    break;
                case EItemType.AnarchicSpiritblade:
                    IconUrl = "Anarchic_Spiritblade_inventory_icon.png";
                    break;
                default:
                    IconUrl = string.Empty;
                    break;
            }

            if (IconUrl != string.Empty)
                IconUrl = "/img/item/base/" + IconUrl;
        }
    }
}
