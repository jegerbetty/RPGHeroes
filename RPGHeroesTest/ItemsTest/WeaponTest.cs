using RPG_Heroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroesTest.ItemsTest
{
    public class WeaponTest
    {
        [Fact]
        public void Create_CreateNewWeapon_ExpectCorrectName()
        {
            //Arrange
            string expectedName = "Excalibur";
            var weapon = new Weapon(expectedName, 1, RPG_Heroes.Enum.Enums.WeaponType.Dagger, 5);

            //Act
            string actualName = weapon.Name;

            //Assert
            Assert.Equal(expectedName, actualName);
        }

        [Fact]
        public void Create_CreateNewWeapon_ExpectCorrectRequiredLevel()
        {
            //Arrange
            var weapon = new Weapon("Excalibur", 1, RPG_Heroes.Enum.Enums.WeaponType.Dagger, 5);
            int expectedRequiredLevel = 1;

            //Act
            int actualRequiredLevel = weapon.RequiredLevel;

            //Assert
            Assert.Equal(expectedRequiredLevel, actualRequiredLevel);
            
        }

        [Fact]
        public void Create_CreateNewWeapon_ExpectCorrectSlot()
        {
            //Arrange
            var weapon = new Weapon("Excalibur", 1, RPG_Heroes.Enum.Enums.WeaponType.Dagger, 5);
            RPG_Heroes.Enum.Enums.Slot expectedSlot = RPG_Heroes.Enum.Enums.Slot.Weapon;

            //Act
            RPG_Heroes.Enum.Enums.Slot actualSlot = weapon.Slot;

            //Assert
            Assert.Equal(expectedSlot, actualSlot);
        }

        [Fact]
        public void Create_CreateNewWeapon_ExpectCorrectWeaponType()
        {
            //Arrange
            var weapon = new Weapon("Excalibur", 1, RPG_Heroes.Enum.Enums.WeaponType.Dagger, 5);
            RPG_Heroes.Enum.Enums.WeaponType expectedWeaponType = RPG_Heroes.Enum.Enums.WeaponType.Dagger;

            //Act
            RPG_Heroes.Enum.Enums.WeaponType actualWeaponType = weapon.WeaponType;

            //Assert
            Assert.Equal(expectedWeaponType, actualWeaponType);
        }
    }
}
