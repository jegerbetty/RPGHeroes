using RPG_Heroes.Enum;
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
        }
        HeroAttribute heroAttribute = new HeroAttribute(5, 2, 1, 3, 2, 1);


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
