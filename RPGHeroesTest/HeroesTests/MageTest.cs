using RPG_Heroes.Heroes;
using RPG_Heroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroesTest.HeroesTests
{
    public class MageTest
    {
        [Fact]
        public void Create_CreateNewMage_ExpectCorrectName()
        {
            //Arrange
            string expectedName = "Alfred";
            var hero = new Mage(expectedName);

            //Act
            string actualName = hero.Name;

            //Assert
            Assert.Equal(expectedName, actualName);

        }

        [Fact]
        public void Create_CreateNewMage_ExpectCorrectLevel()
        {
            //Arrange
            var hero = new Mage("Alfred");
            int expectedLevel = 1;

            //Act
            int actualLevel = hero.Level;

            //Assert
            Assert.Equal(expectedLevel, actualLevel);
        }

        [Fact]
        public void Create_CreateNewMage_ExpectCorrectAttributes()
        {
            //Arrange
            var hero = new Mage("Alfred");
            HeroAttribute expectedAttributes = new(1, 1, 8, 1, 1, 5);

            //Act
            HeroAttribute actualAttributes = hero.HeroAttribute;

            //Assert
            Assert.Equal(expectedAttributes, actualAttributes); //Results in Assert.Equal() fail, but the results (expected and actual) are the same. 
        }

        [Fact]
        public void LevelUp_WhenLevellingUpMage_ExpectCorrectIncreasedAttributes()
        {
            //Arrange
            var hero = new Mage("Alfred");
            HeroAttribute levelOneAttributes = hero.HeroAttribute;
            HeroAttribute expectedLevelTwoAttributes = new(levelOneAttributes.Strength +1, levelOneAttributes.Dexterity +1, levelOneAttributes.Intelligence +5, levelOneAttributes.LevelUpStrength, levelOneAttributes.LevelUpDexterity, levelOneAttributes.LevelUpIntelligence);

            //Act
            hero.LevelUp();
            HeroAttribute actualLevelTwoAttributes = hero.HeroAttribute;

            //Assert
            Assert.Equal(expectedLevelTwoAttributes, actualLevelTwoAttributes); //Results in Assert.Equal() fail, but the results (expected and actual) are the same. 
        }

        [Fact]
        public void EquipWeapon_ExpectCorrectLevelRequirement()
        {
            //Arrange
            var hero = new Mage("Alfred");
            Weapon weapon = new Weapon("Magic Stick", 1, RPG_Heroes.Enum.Enums.WeaponType.Wand, 5);
            int expectedRequiredLevel = 1;

            //Act
            hero.EquipWeapon(weapon);
            int actualRequiredLevel = hero.EquippedWeapon.RequiredLevel;

            //Assert
            Assert.Equal(expectedRequiredLevel, actualRequiredLevel);
        }
    }
}
