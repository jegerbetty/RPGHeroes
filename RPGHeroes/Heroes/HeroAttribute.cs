using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes.Heroes
{
    public class HeroAttribute
    {
        /*Strength – determines the physical strength of the character.
        *• Dexterity – determines the characters ability to attack with speed and nimbleness.
        *• Intelligence – determines the characters affinity with magic.
        *
        *This class should have methods to add two instances together and return the sum 
        *OR increase the one instance by a specified amount. 
        *Which to use is up to you on what best suits your solution.
        *EB: make method for levellingup here so that when level increases, strength, decterity and inteligence increases
        *
        *NOTE: This class is used as the datatype for both LevelAttributes.
        *
        *From Armor class: I have added this to Armor class - don't think it's necessary here. 
        *In addition to an armor type, armor has attributes which provide bonuses to a heroes attributes when equipped. 
        *This field is of type HeroAttribute and should be called ArmorAttribute.
        */

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int LevelUpStrength { get; set; }
        public int LevelUpDexterity { get; set; }
        public int LevelUpIntelligence { get; set; }
 
        

        public HeroAttribute(int strength, int dexterity, int intelligence, int levelUpStrength, int levelUpDexterity, int levelUpIntelligence)
        {
            this.Strength = strength;
            this.Dexterity = dexterity;
            this.Intelligence = intelligence;

            this.LevelUpStrength = levelUpStrength;
            this.LevelUpDexterity = levelUpDexterity;
            this.LevelUpIntelligence = levelUpIntelligence;
        }
    }
}
