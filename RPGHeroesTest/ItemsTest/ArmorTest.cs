using RPG_Heroes.Heroes;
using RPG_Heroes.Enum;
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
            var armor = new RPG_Heroes.Items.Armor(Enums.ArmorType.Leather, expectedName, new HeroAttribute(1, 1, 8, 1, 1, 5), Enums.Slot.Body, 1);

            //Act
            string actualName = armor.Name;

            //Assert
            Assert.Equal(expectedName, actualName);
        }

        [Fact]
        public void Create_CreateNewArmor_ExpectCorrectRequiredLevel()
        {
            //Arrange
            var armor = new RPG_Heroes.Items.Armor(Enums.ArmorType.Leather, "Trusty Protection", new HeroAttribute(1, 1, 8, 1, 1, 5), Enums.Slot.Body, 1);
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
            var armor = new RPG_Heroes.Items.Armor(Enums.ArmorType.Leather, "Trusty Protection", new HeroAttribute(1, 1, 8, 1, 1, 5), Enums.Slot.Body, 1);
            Enums.Slot expectedSlot = Enums.Slot.Body;

            //Act
            Enums.Slot actualSlot = armor.Slot;

            Assert.Equal(expectedSlot, actualSlot);
        }

        [Fact]
        public void Create_CreateNewArmor_ExpectCorrectArmorType()
        {
            //Arrange
            var armor = new RPG_Heroes.Items.Armor(Enums.ArmorType.Leather, "Trusty Protection", new HeroAttribute(1, 1, 8, 1, 1, 5), Enums.Slot.Body, 1);
            Enums.ArmorType expectedArmorType = Enums.ArmorType.Leather;

            //Act
            Enums.ArmorType actualArmorType = armor.ArmorType;

            //Assert
            Assert.Equal(expectedArmorType, actualArmorType);
        }

        [Fact]
        public void Create_CreateNewArmor_ExpectCorrectArmorAttributes()
        {
            //Arrange
            var armor = new RPG_Heroes.Items.Armor(Enums.ArmorType.Leather, "Trusty Protection", new HeroAttribute(1, 1, 8, 1, 1, 5), Enums.Slot.Body, 1);
            HeroAttribute expectedArmorAttribute = new HeroAttribute(1, 1, 8, 1, 1, 5);

            //Act
            HeroAttribute actualArmorAttribute = armor.ArmorAttribute;

            //Assert
            Assert.Equal(expectedArmorAttribute, actualArmorAttribute); //Results in Assert.Equal() fail, but the results (expected and actual) are the same.
        }
    }
}
