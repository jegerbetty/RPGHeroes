using RPG_Heroes.Items;
using RPG_Heroes.Enum;
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
            Weapon weapon = new Weapon(expectedName, 1, Enums.WeaponType.Dagger, 5);

            //Act
            string actualName = weapon.Name;

            //Assert
            Assert.Equal(expectedName, actualName);
        }

        [Fact]
        public void Create_CreateNewWeapon_ExpectCorrectRequiredLevel()
        {
            //Arrange
            Weapon weapon = new Weapon("Excalibur", 1, Enums.WeaponType.Dagger, 5);
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
            Weapon weapon = new Weapon("Excalibur", 1, Enums.WeaponType.Dagger, 5);
            Enums.Slot expectedSlot = Enums.Slot.Weapon;

            //Act
            Enums.Slot actualSlot = weapon.Slot;

            //Assert
            Assert.Equal(expectedSlot, actualSlot);
        }

        [Fact]
        public void Create_CreateNewWeapon_ExpectCorrectWeaponType()
        {
            //Arrange
            Weapon weapon = new Weapon("Excalibur", 1, Enums.WeaponType.Dagger, 5);
            Enums.WeaponType expectedWeaponType = Enums.WeaponType.Dagger;

            //Act
            Enums.WeaponType actualWeaponType = weapon.WeaponType;

            //Assert
            Assert.Equal(expectedWeaponType, actualWeaponType);
        }

        [Fact]
        public void Create_CreateNewWeapon_ExpectCorrectDamage()
        {
            //Arrange
            Weapon weapon = new Weapon("Excalibur", 1, Enums.WeaponType.Dagger, 5);
            int expectedWeaponDamage = 5;

            //Act
            int actualWeaponDamage = weapon.WeaponDamage;

            //Assert
            Assert.Equal(expectedWeaponDamage, actualWeaponDamage);
        }
    }
}
