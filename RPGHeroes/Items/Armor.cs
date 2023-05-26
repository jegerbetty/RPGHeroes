using RPG_Heroes.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RPG_Heroes.Enum.Enums;

namespace RPG_Heroes.Items
{
    public class Armor : Items
    {
        public ArmorType ArmorType { get; set; }
        public HeroAttribute ArmorAttribute { get; set; } //tell property for bonus attributes the armor gives hero

        public Armor(ArmorType armorType, string name, HeroAttribute attribute, Slot slot, int requiredLevel) : base(name, requiredLevel, slot)
        {
            ArmorType = armorType;
            Name = name;
            ArmorAttribute = new (attribute.Strength, attribute.Dexterity, attribute.Intelligence, attribute.LevelUpStrength, attribute.LevelUpDexterity, attribute.LevelUpIntelligence);
            Slot = slot;
            RequiredLevel = requiredLevel;
        }
    }
}
