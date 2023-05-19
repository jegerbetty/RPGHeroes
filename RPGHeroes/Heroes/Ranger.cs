using RPG_Heroes.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes.Heroes
{
    public class Ranger : Hero
    {
        /*Ranger attribute gain
        *A Ranger begins at level 1 with
        *Strength: 1
        *Dexterity: 7
        *Intelligence: 1
        *Every time a Ranger levels up, they gain
        *Strength: 1
        *Dexterity: 5
        *Intelligence: 1
        *
        *Weapon types permitted to equip: Bow - how to set?
        *
        *Armor types permitted to equip: Leather, Mail - how to set?
        */
        public Ranger(string name) : base(name)
        {
        }
        HeroAttribute heroAttribute = new HeroAttribute(1, 7, 1, 1, 5, 1);
       
    }
}
