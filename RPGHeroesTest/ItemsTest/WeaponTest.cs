﻿using RPG_Heroes.Items;
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

    }
}
