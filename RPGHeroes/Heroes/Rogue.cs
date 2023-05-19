using RPG_Heroes.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes.Heroes
{
    public class Rogue : Hero
    {
        /*Rogue attribute gain
        *A Rogue begins at level 1 with
        *Strength: 2
        *Dexterity: 6
        *Intelligence: 1
        *Every time a Rogue levels up, they gain
        *Strength: 1
        *Dexterity: 4
        *Intelligence: 1
        *
        *Weapon types permitted to equip: Dagger, Sword - how to set?
        *
        *Armor types permitted to equip: Leather, Mail - how to set?
        */
        public Rogue(string name) : base(name)
        {
        }
        HeroAttribute heroAttribute = new HeroAttribute(2, 6, 1, 1, 4, 1);
        
    }
}
