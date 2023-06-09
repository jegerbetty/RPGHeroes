﻿using RPG_Heroes.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroesTest.HeroesTests
{
    public class WarriorTest
    {
        [Fact]
        public void Create_CreateNewWarrior_ExpectCorrectName()
        {
            //Arrange
            string expectedName = "Harald";
            Warrior hero = new Warrior(expectedName);

            //Act
            string actualName = hero.Name;

            //Assert
            Assert.Equal(expectedName, actualName);

        }

        [Fact]
        public void Create_CreateNewWarrior_ExpectCorrectLevel()
        {
            //Arrange
            Warrior hero = new Warrior("Harald");
            int expectedLevel = 1;

            //Act
            int actualLevel = hero.Level;

            //Assert
            Assert.Equal(expectedLevel, actualLevel);
        }

        [Fact]
        public void Create_CreateNewWarrior_ExpectCorrectAttributes()
        {
            //Arrange
            Warrior hero = new Warrior("Harald");
            HeroAttribute expectedAttributes = new(5,2,1,3,2,1);

            //Act
            HeroAttribute actualAttributes = hero.HeroAttribute;

            //Assert
            Assert.Equal(expectedAttributes, actualAttributes); //Results in Assert.Equal() fail, but the results (expected and actual) are the same. 
        }

        [Fact]
        public void LevelUp_WhenLevellingUpWarrior_ExpectCorrectIncreasedAttributes()
        {
            //Arrange
            Warrior hero = new Warrior("Harald");
            HeroAttribute levelOneAttributes = hero.HeroAttribute;
            HeroAttribute expectedLevelTwoAttributes = new(levelOneAttributes.Strength + 3, levelOneAttributes.Dexterity + 2, levelOneAttributes.Intelligence + 1, levelOneAttributes.LevelUpStrength, levelOneAttributes.LevelUpDexterity, levelOneAttributes.LevelUpIntelligence);

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
            Warrior hero = new Warrior("Harald");
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
