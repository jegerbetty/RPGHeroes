using RPG_Heroes.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroesTest.ItemsTest
{
    public class ArmorTest
    {
        [Fact]
        public void Create_CreateNewArmor_ExpectCorrectName()
        {
            //Arrange
            string expectedName = "Trusty Protection";
            var armor = new RPG_Heroes.Items.Armor(RPG_Heroes.Enum.Enums.ArmorType.Leather, expectedName, new RPG_Heroes.Heroes.HeroAttribute(1, 1, 8, 1, 1, 5), RPG_Heroes.Enum.Enums.Slot.Body, 1);

            //Act
            string actualName = armor.Name;

            //Assert
            Assert.Equal(expectedName, actualName);
        }

        [Fact]
        public void Create_CreateNewArmor_ExpectCorrectRequiredLevel()
        {
            //Arrange
            var armor = new RPG_Heroes.Items.Armor(RPG_Heroes.Enum.Enums.ArmorType.Leather, "Trusty Protection", new RPG_Heroes.Heroes.HeroAttribute(1, 1, 8, 1, 1, 5), RPG_Heroes.Enum.Enums.Slot.Body, 1);
            int expectedRequiredLevel = 1;

            //Act
            int actualRequiredLevel = armor.RequiredLevel;

            //Assert
            Assert.Equal(expectedRequiredLevel, actualRequiredLevel);
        }

        [Fact]
        public void Create_CreateNewArmor_ExpectCorrectSlot()
        {
            //Arrange
            var armor = new RPG_Heroes.Items.Armor(RPG_Heroes.Enum.Enums.ArmorType.Leather, "Trusty Protection", new RPG_Heroes.Heroes.HeroAttribute(1, 1, 8, 1, 1, 5), RPG_Heroes.Enum.Enums.Slot.Body, 1);
            RPG_Heroes.Enum.Enums.Slot expectedSlot = RPG_Heroes.Enum.Enums.Slot.Body;

            //Act
            RPG_Heroes.Enum.Enums.Slot actualSlot = armor.Slot;

            Assert.Equal(expectedSlot, actualSlot);
        }

        [Fact]
        public void Create_CreateNewArmor_ExpectCorrectArmorType()
        {
            //Arrange
            var armor = new RPG_Heroes.Items.Armor(RPG_Heroes.Enum.Enums.ArmorType.Leather, "Trusty Protection", new RPG_Heroes.Heroes.HeroAttribute(1, 1, 8, 1, 1, 5), RPG_Heroes.Enum.Enums.Slot.Body, 1);
            RPG_Heroes.Enum.Enums.ArmorType expectedArmorType = RPG_Heroes.Enum.Enums.ArmorType.Leather;

            //Act
            RPG_Heroes.Enum.Enums.ArmorType actualArmorType = armor.ArmorType;

            //Assert
            Assert.Equal(expectedArmorType, actualArmorType);
        }

        [Fact]
        public void Create_CreateNewArmor_ExpectCorrectArmorAttributes()
        {
            //Arrange
            var armor = new RPG_Heroes.Items.Armor(RPG_Heroes.Enum.Enums.ArmorType.Leather, "Trusty Protection", new RPG_Heroes.Heroes.HeroAttribute(1, 1, 8, 1, 1, 5), RPG_Heroes.Enum.Enums.Slot.Body, 1);
            HeroAttribute expectedArmorAttribute = new(1, 1, 8, 1, 1, 5);

            //Act
            HeroAttribute actualArmorAttribute = armor.ArmorAttribute;

            //Assert
            Assert.Equal(expectedArmorAttribute, actualArmorAttribute); //Results in Assert.Equal() fail, but the results (expected and actual) are the same.
        }
    }
}
