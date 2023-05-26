using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RPG_Heroes.Enum.Enums;

namespace RPG_Heroes.Items
{
    public class Weapon : Items
    {
        public WeaponType WeaponType { get; set; }
        public int WeaponDamage { get; set; }
               

        public Weapon(string name, int requiredLevel, WeaponType weaponType, int weaponDamage) : base(name, requiredLevel, Slot.Weapon)
        {
            WeaponType = weaponType;
            WeaponDamage = weaponDamage;
        }
    }
}
