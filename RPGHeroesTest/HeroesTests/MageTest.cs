using RPG_Heroes.Heroes;
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
            Assert.Equal(expectedAttributes, actualAttributes);
        }
    }
}
