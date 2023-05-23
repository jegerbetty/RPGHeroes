using RPG_Heroes.Enum;
using RPG_Heroes.Exceptions;
using RPG_Heroes.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static RPG_Heroes.Enum.Enums;
using static RPG_Heroes.Items.Items;

namespace RPG_Heroes.Heroes
{
    public abstract class Hero
    {
      
        public string Name { get; set; }
        public int Level { get; set; }
        public string? ClassName { get; set; }

        //public HeroAttribute? LevelAttributes { get; set; }
        public HeroAttribute? HeroAttribute { get; set; }
        //public HeroAttribute? DamagingAttribute { get; set; }

        public Weapon? EquippedWeapon { get; set; }
        public Dictionary<Slot, Items.Items> EquippedArmor { get; set; }
        public WeaponType[]? ValidWeaponTypes { get; set; }
        public ArmorType[]? ValidArmorTypes { get; set; }

        public Hero(string name)
        {
            Name = name;
            Level = 1;
            EquippedArmor = new Dictionary<Slot, Items.Items>(); 
        }

        
      
        public void LevelUp()
        {
            Level++;
            HeroAttribute.Strength += HeroAttribute.LevelUpStrength;
            HeroAttribute.Dexterity += HeroAttribute.LevelUpDexterity;
            HeroAttribute.Intelligence += HeroAttribute.LevelUpIntelligence;
            //increase level by 1, and increase strenth, dexterity and intelligence
        }
        public void EquipArmor(Armor armorToEquip)
        {
            if((!ValidArmorTypes.Contains(armorToEquip.ArmorType) || (armorToEquip.RequiredLevel > Level)))
                {
                throw new InvalidArmorException();
            }
            else
            {
                EquippedArmor.Remove(armorToEquip.Slot);
                EquippedArmor.Add(armorToEquip.Slot, armorToEquip);
            }
        }
        public void EquipWeapon(Weapon weaponToEquip)
        {
            if(!ValidWeaponTypes.Contains(weaponToEquip.WeaponType) || (weaponToEquip.RequiredLevel > Level)) 
            {
                throw new InvalidWeaponException();
            } 
            else 
            {

                EquippedWeapon = weaponToEquip;
            }
        }
        public abstract int Damage();


        public abstract HeroAttribute TotalAttributes();
        
        
            public void DisplayHero()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Character name: {Name}\n");
            sb.AppendFormat($"Character class: {ClassName}\n");
            sb.AppendFormat($"Character level: {Level}\n");
            sb.AppendFormat($"Character total strength: {TotalAttributes().Strength}\n"); 
            sb.AppendFormat($"Character total dexterity: {TotalAttributes().Dexterity}\n"); 
            sb.AppendFormat($"Character total intelligence: {TotalAttributes().Intelligence}\n"); 
            sb.AppendFormat($"Character total damage: {Damage()}\n");
        }
    }
}
