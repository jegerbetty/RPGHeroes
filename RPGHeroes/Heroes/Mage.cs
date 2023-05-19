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
            HeroAttribute heroAttribute = new HeroAttribute(1, 1, 8, 1, 1, 5);
            DamagingAttribute = HeroAttribute.Intelligence; //Warrior: Strength, Ranger: Dexterity, Rogue: Dexterity
        }
        public override int Damage()
        {
            int heroDamage = 0;

            if (EquippedWeapon == null)
            {
                heroDamage = 1 * (1 + (int)DamagingAttribute.Intelligence / 100);
            }
            else
            {
                heroDamage = EquippedWeapon.WeaponDamage * (1 + (int)HeroAttribute.Intelligence / 100);
            }
            return heroDamage;
        }




    }
}
