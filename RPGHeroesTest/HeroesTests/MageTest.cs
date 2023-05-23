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
        
    }
}
