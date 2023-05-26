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
