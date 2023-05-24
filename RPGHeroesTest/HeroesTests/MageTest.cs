using RPG_Heroes.Exceptions;
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

        [Fact]
        public void EquipWeapon_ExpectCorrectWeaponType() 
        {
            //Arrange
            var hero = new Mage("Alfred");
            Weapon weapon = new Weapon("Magic Stick", 1, RPG_Heroes.Enum.Enums.WeaponType.Wand, 5);
            RPG_Heroes.Enum.Enums.WeaponType expectedEquipableWeaponType = RPG_Heroes.Enum.Enums.WeaponType.Wand;

            //Act
            hero.EquipWeapon(weapon);
            RPG_Heroes.Enum.Enums.WeaponType actualEquipableWeaponType = hero.EquippedWeapon.WeaponType;

            //Assert
            Assert.Equal(expectedEquipableWeaponType, actualEquipableWeaponType);
        }

        /*  [Fact]
         public void EquipArmor_ExpectCorrectArmorType()
          {
        //Arrange
             var hero = new Mage("Alfred");
             Armor armor = new Armor(RPG_Heroes.Enum.Enums.ArmorType.Cloth, "Trusty Protection", new RPG_Heroes.Heroes.HeroAttribute(1, 1, 8, 1, 1, 5), RPG_Heroes.Enum.Enums.Slot.Body, 1);
             RPG_Heroes.Enum.Enums.ArmorType expectedEquipableArmorType = RPG_Heroes.Enum.Enums.ArmorType.Cloth;

        //Act
             hero.EquipArmor(armor);
             RPG_Heroes.Enum.Enums.ArmorType actualEquipableArmorType = hero.EquippedArmor[RPG_Heroes.Enum.Enums.Slot.Body].; //don't know what comes at the end here to make it work

        //Assert
             Assert.Equal(expectedEquipableArmorType, actualEquipableArmorType);
         } */

        [Fact]
        public void EquipArmor_NoArmor_ExpectCorrectTotalAttributes()
        {
            //Arrange
            var hero = new Mage("Alfred");
            HeroAttribute expectedTotalAttributes = new(1, 1, 8, 1, 1, 5);

            //Act
            HeroAttribute actualTotalAttributes = hero.TotalAttributes();

            //Assert
            Assert.Equal(expectedTotalAttributes, actualTotalAttributes); //Results in Assert.Equal() fail, but the results (expected and actual) are the same. 
        }

        [Fact]
        public void EquipArmor_OnePieceOfArmor_ExpectCorrectTotalAttributes()
        {
            //Arrange
            var hero = new Mage("Alfred");
            Armor armor = new Armor(RPG_Heroes.Enum.Enums.ArmorType.Cloth, "Trusty Protection", new RPG_Heroes.Heroes.HeroAttribute(1, 1, 1, 0, 0, 0), RPG_Heroes.Enum.Enums.Slot.Body, 1);
            HeroAttribute expectedTotalAttributes = new(2, 2, 9, 1, 1, 5);

            //Act
            hero.EquipArmor(armor);
            HeroAttribute actualTotalAttributes = hero.TotalAttributes();

            //Assert
            Assert.Equal(expectedTotalAttributes, actualTotalAttributes); //Results in Assert.Equal() fail, but the results (expected and actual) are the same. 
        }

        [Fact]
        public void EquipArmor_TwoPiecesOfArmor_ExpectCorrectTotalAttributes()
        {
            //Arrange
            var hero = new Mage("Alfred");
            Armor armor = new Armor(RPG_Heroes.Enum.Enums.ArmorType.Cloth, "Trusty Protection", new RPG_Heroes.Heroes.HeroAttribute(1, 1, 1, 0, 0, 0), RPG_Heroes.Enum.Enums.Slot.Body, 1);
            Armor armorHead = new Armor(RPG_Heroes.Enum.Enums.ArmorType.Cloth, "Trusty Helmet", new RPG_Heroes.Heroes.HeroAttribute(1, 1, 1, 0, 0, 0), RPG_Heroes.Enum.Enums.Slot.Head, 1);
            HeroAttribute expectedTotalAttributes = new(3, 3, 10, 1, 1, 5);

            //Act
            hero.EquipArmor(armor);
            hero.EquipArmor(armorHead);
            HeroAttribute actualTotalAttributes = hero.TotalAttributes();

            //Assert
            Assert.Equal(expectedTotalAttributes, actualTotalAttributes); //Results in Assert.Equal() fail, but the results (expected and actual) are the same. 
        }

        [Fact]
        public void EquipArmor_ReplacedPieceOfArmor_ExpectCorrectTotalAttributes()
        {
            //Arrange
            var hero = new Mage("Alfred");
            Armor armor = new Armor(RPG_Heroes.Enum.Enums.ArmorType.Cloth, "Trusty Protection", new RPG_Heroes.Heroes.HeroAttribute(1, 1, 1, 0, 0, 0), RPG_Heroes.Enum.Enums.Slot.Body, 1);
            Armor armorHead = new Armor(RPG_Heroes.Enum.Enums.ArmorType.Cloth, "Trusty Helmet", new RPG_Heroes.Heroes.HeroAttribute(4, 4, 4, 0, 0, 0), RPG_Heroes.Enum.Enums.Slot.Body, 1);
            HeroAttribute expectedTotalAttributes = new(5, 5, 12, 1, 1, 5);

            //Act
            hero.EquipArmor(armor);
            hero.EquipArmor(armorHead);
            HeroAttribute actualTotalAttributes = hero.TotalAttributes();

            //Assert
            Assert.Equal(expectedTotalAttributes, actualTotalAttributes); //Results in Assert.Equal() fail, but the results (expected and actual) are the same. 
        }
    }
}
