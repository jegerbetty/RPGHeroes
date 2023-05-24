using RPG_Heroes.Enum;
using RPG_Heroes.Exceptions;
using RPG_Heroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static RPG_Heroes.Enum.Enums;

namespace RPG_Heroes.Heroes
{
    public class Mage : Hero
    {
        
        public Mage(string name) : base(name)
        {
            Name = name;
            ClassName = "Mage";
            EquippedWeapon = EquippedWeapon;
            ValidWeaponTypes = new Enums.WeaponType[] { Enums.WeaponType.Staff, Enums.WeaponType.Wand };
            ValidArmorTypes = new Enums.ArmorType[] { Enums.ArmorType.Cloth };
            HeroAttribute = new HeroAttribute(1, 1, 8, 1, 1, 5);
            
        }

        public override HeroAttribute TotalAttributes()
        {
            int totalStrength = HeroAttribute.Strength;
            int totalDexterity = HeroAttribute.Dexterity;
            int totalIntelligence = HeroAttribute.Intelligence;
            int totalLevelUpStrength = HeroAttribute.LevelUpStrength;
            int totalLevelUpDexterity = HeroAttribute.LevelUpDexterity;
            int totalLevelUpIntelligence = HeroAttribute.LevelUpIntelligence;

            
            foreach (var item in EquippedArmor.Values)
            {
                if (item is Armor armor) 
                { 
                totalStrength += armor.ArmorAttribute.Strength;
                totalDexterity += armor.ArmorAttribute.Dexterity;
                totalIntelligence += armor.ArmorAttribute.Intelligence;
                totalLevelUpStrength += armor.ArmorAttribute.LevelUpStrength;
                totalLevelUpDexterity += armor.ArmorAttribute.LevelUpDexterity;
                totalLevelUpIntelligence += armor.ArmorAttribute.LevelUpIntelligence;
                }
            }
            HeroAttribute totalAttributes = new(totalStrength, totalDexterity, totalIntelligence, totalLevelUpStrength, totalLevelUpDexterity, totalLevelUpIntelligence);

            return totalAttributes;
        }

        public override double Damage()
        {
            double heroDamage = 0;

            if (EquippedWeapon == null)
            {
                heroDamage = 1 * (1 + (double)TotalAttributes().Intelligence / 100);
            }
            else
            {
                heroDamage = EquippedWeapon.WeaponDamage * (1 + (double)TotalAttributes().Intelligence / 100);
            }
            return heroDamage;
        }




    }
}
