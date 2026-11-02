using SoloSelfTracking.Enumerations;
using System;
using System.Collections.Generic;

namespace SoloSelfTracking.Models
{
    public abstract class Item
    {
        // Unique identifier for tracking this item in the application.
        public string Id { get; set; }

        // Display information
        public string Name { get; set; } = string.Empty;
        public string TypeLine { get; set; } = string.Empty;
        public EItemType BaseType { get; set; } = EItemType.Unknown;
        public EItemRarity Rarity { get; set; } = EItemRarity.Normal;
        public int ItemLevel { get; set; }
        public bool Identified { get; set; } = true;
        public bool Corrupted { get; set; }
        public bool Mirrored { get; set; }
        public bool Fractured { get; set; }
        public int StackSize { get; set; } = 1;
        public int MaxStackSize { get; set; } = 1;
        public List<ItemSocket> Sockets { get; set; } = new();
        public int IntRequirement { get; set; } = 0;
        public int DexRequirement { get; set; } = 0;
        public int StrRequirement { get; set; } = 0;
        public int LevelRequirement { get; set; } = 0;
        public List<string> ImplicitModifiers { get; set; } = new();
        public List<string> ExplicitModifiers { get; set; } = new();
        public List<string> CraftedModifiers { get; set; } = new();
        public List<string> Enchantments { get; set; } = new();
        public string? IconUrl { get; set; }
        public string? Notes { get; set; }

        protected Item()
        {
        }

        protected Item(string name, EItemType baseType, EItemRarity rarity)
        {
            Name = name;
            BaseType = baseType;
            Rarity = rarity;
        }

        public virtual bool IsStackable =>
            MaxStackSize > 1;

        public virtual bool IsFullyStacked =>
            IsStackable && StackSize >= MaxStackSize;

        public virtual string DisplayName =>
            string.IsNullOrWhiteSpace(Name) ? TypeLine : Name;

        public override string ToString() => DisplayName;

        public string GetItemKey()
        {
            return Name.ToLower().Replace(' ', '-');
        }


        public List<string> GetVariants()
        {
            var variants = new List<string>();

            foreach (var text in ExplicitModifiers)
            {
                if (text.Contains("{variant:"))
                {
                    variants.Add(text.Split("}")[1]);
                }
            }

            return variants;
        }

        public List<string> GetVariantText(string variant)
        {
            throw new NotImplementedException();
        }
    }

    public class ItemSocket
    {
        public string Colour { get; set; } = string.Empty;
        public int Group { get; set; }

        public ItemSocket()
        {
        }

        public ItemSocket(string colour, int group = 0)
        {
            Colour = colour;
            Group = group;
        }
    }
}