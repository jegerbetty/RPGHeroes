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
        /*Mage attribute gain
        *A Mage begins at level 1 with
        *Strength: 1
        *Dexterity: 1
        *Intelligence: 8
        *Every time a Mage levels up, they gain
        *Strength: 1
        *Dexterity: 1
        *Intelligence: 5
        *
        *Weapon types permitted to equip: Staff, Wand - how to set? attempted notes below
        *
        *Armor types permitted to equip: Cloth - how to set? attempted notes below
        *
        *
        *
        *Weapon mage1 = Weapon.WeaponType;
        *if (mage1 == WeaponType.Bow)
        *{InvalidWeaponException}
        */
        //public string[] validWeaponType = { "Staff", "Wand" };
        //public string[] validArmorType = { "Cloth" };




        //ValidWeaponTypes = new enum { } validWeaponType {  "Staff", "Wand" };

        //HeroAttribute = new HeroAttribute(1,1,8,1,1,5);
        public Mage(string name) : base(name)
        {
            Name = name;
            ClassName = "Mage";
            EquippedWeapon = EquippedWeapon;
            ValidWeaponTypes = new Enums.WeaponType[] { Enums.WeaponType.Staff, Enums.WeaponType.Wand };
            ValidArmorTypes = new Enums.ArmorType[] { Enums.ArmorType.Cloth };
            HeroAttribute heroAttribute = new HeroAttribute(1, 1, 8, 1, 1, 5);
            HeroAttribute.DamagingAttribute = HeroAttribute.Intelligence; //Warrior: Strength, Ranger: Dexterity, Rogue: Dexterity
        }

        
        
       
    }
}
