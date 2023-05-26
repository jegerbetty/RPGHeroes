# RPGHeroes
This project is the first assignment in the Back-end Web Development with .NET course I am currently undertaking. 
The assignment is to build a console application in .NET, using C#. The theme is RPG Heroes. 
Main outline:
* Hero classes: Have attributes that increase at different rates as the character gains levels
* Equipment: Weapon and armor that the heroes can equip. Equipment will give the hero more power or damage. Certain heroes can only equip certain item types
* Custom exceptions: There must be custom exceptions when weapon and armor is equipped, but the required level is too high for the hero, or the items are not valid for the hero
* Testing: Using XUnit testing, the main functionality needs to be tested

## Tools
I have used the following to make this console application: 
* C#
* .NET6
* Microsoft Visual Studio 2022
* XUnit

## Description of content in classes in Hero file
The Hero class is the parent class for the child class heroes: Mage, Ranger, Rogue and Warrior
All heroes should have the following shared fields:
* Name
* Level (all heroes start at Level 1)
* LevelAttributes (total from all levels)
* Equipment (currently equipped items: weapon and armor)
* ValidWeaponTypes (List of the weapon types a certain hero can equip)
* ValidArmorTypes (List of the armor types a certain hero can equip)

All heroes should have the following public facing methods: 
* Constructor (each hero is created by passing just a **name**)
* LevelUp (increases the level of a hero by 1, and increases their LevelAttributes)
* Equip (one for equipping weapon, one for equipping armor)
* Damage (calculate damage with the following calculation: Hero damage = WeaponDamage * (1 + DamagingAttribute/100)) - each hero has a damaging attribute, either strength, intelligence or dexterity
* TotalAttributes (calculate total attributes with the following calculation: Total = LevelAttributes + (Sum of ArmorAttribute for all Armor in Equipment)) 
* Display (the following details of the hero should be displayed: Name, Class, Level, Total strength, Total dexterity, Total intelligence, Damage)

HeroAttributes class shall encapsulate the following attributes:
* Strength
* Dexterity
* Intelligence
I have included the levelling attributes in the HeroAttributes class. Levelling attributes are what the hero's attributes incease with when they level up. 

## Description of content in classes in Items file
The Items class is the parent class to both armor and weapon. Alle items share the following fields:
* Name
* RequiredLevel
* Slot


## Description of content in class in Enum file
The assigment asked that we should make Slots, Weapons, and Armor as enumerators. 
Existing slots, Weapons and Armor are therefore included here. 

## Description of content in classes in Exceptions file
The required custom exceptions were made as individual classes in this file. 
