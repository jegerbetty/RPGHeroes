﻿using RPG_Heroes.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroesTest.HeroesTests
{
    public class RogueTest
    {
        [Fact]
        public void Create_CreateNewRogue_ExpectCorrectName()
        {
            //Arrange
            string expectedName = "Balrog";
            Rogue hero = new Rogue(expectedName);

            //Act
            string actualName = hero.Name;

            //Assert
            Assert.Equal(expectedName, actualName);

        }

        [Fact]
        public void Create_CreateNewRogue_ExpectCorrectLevel()
        {
            //Arrange
            Rogue hero = new Rogue("Balrog");
            int expectedLevel = 1;

            //Act
            int actualLevel = hero.Level;

            //Assert
            Assert.Equal(expectedLevel, actualLevel);
        }

        [Fact]
        public void Create_CreateNewRogue_ExpectCorrectAttributes()
        {
            //Arrange
            Rogue hero = new Rogue("Balrog");
            HeroAttribute expectedAttributes = new(2, 6, 1, 1, 4, 1);

            //Act
            HeroAttribute actualAttributes = hero.HeroAttribute;

            //Assert
            Assert.Equal(expectedAttributes, actualAttributes); //Results in Assert.Equal() fail, but the results (expected and actual) are the same. 
        }

        [Fact]
        public void LevelUp_WhenLevellingUpRogue_ExpectCorrectIncreasedAttributes()
        {
            //Arrange
            Rogue hero = new Rogue("Balrog");
            HeroAttribute levelOneAttributes = hero.HeroAttribute;
            HeroAttribute expectedLevelTwoAttributes = new(levelOneAttributes.Strength + 1, levelOneAttributes.Dexterity + 4, levelOneAttributes.Intelligence + 1, levelOneAttributes.LevelUpStrength, levelOneAttributes.LevelUpDexterity, levelOneAttributes.LevelUpIntelligence);

            //Act
            hero.LevelUp();
            HeroAttribute actualLevelTwoAttributes = hero.HeroAttribute;

            //Assert
            Assert.Equal(expectedLevelTwoAttributes, actualLevelTwoAttributes); //Results in Assert.Equal() fail, but the results (expected and actual) are the same. 
        }

        [Fact]
        public void Display_DisplayHero_ExpectDisplayedState()
        {
            //Arrange
            Rogue hero = new Rogue("Balrog");
            string expectedDisplayedState =
            $"Character name: {hero.Name}\n" +
            $"Character class: {hero.ClassName}\n" +
            $"Character level: {hero.Level}\n" +
            $"Character total strength: {hero.TotalAttributes().Strength}\n" +
            $"Character total dexterity: {hero.TotalAttributes().Dexterity}\n" +
            $"Character total intelligence: {hero.TotalAttributes().Intelligence}\n" +
            $"Character total damage: {hero.Damage()}\n";

            //Act
            string actualDisplayedState = hero.DisplayHero();

            //Assert
            Assert.Equal(expectedDisplayedState, actualDisplayedState);

        }
    }
}
