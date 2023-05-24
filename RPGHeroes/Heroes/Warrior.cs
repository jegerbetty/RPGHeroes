using RPG_Heroes.Enum;
using RPG_Heroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes.Heroes
{
    public class Warrior : Hero
    {
        
        public Warrior(string name) : base(name)
        {
            HeroAttribute = new HeroAttribute(5, 2, 1, 3, 2, 1);
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
        public override int Damage()
        {
            int heroDamage = 0;

            if (EquippedWeapon == null)
            {
                heroDamage = 1 * (1 + (int)TotalAttributes().Strength / 100);
            }
            else
            {
                heroDamage = EquippedWeapon.WeaponDamage * (1 + (int)TotalAttributes().Strength / 100);
            }
            return heroDamage;
        }

    }
}
