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
        /*Warrior attribute gain
        *A Warrior begins at level 1 with
        *Strength: 5
        *Dexterity: 2
        *Intelligence: 1
        *Every time a Warrior levels up, they gain
        *Strength: 3
        *Dexterity: 2
        *Intelligence: 1
        *
        *Weapon types permitted to equip: Axe, Hammer, Sword - how to set?
        *
        *Armor types permitted to equip: Mail, Plate - how to set?
        */
        public Warrior(string name) : base(name)
        {
        }
        HeroAttribute heroAttribute = new HeroAttribute(5, 2, 1, 3, 2, 1);
        
        
    }
}
