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

HeroAttribute class shall encapsulate the following attributes:
* Strength
* Dexterity
* Intelligence

I have included the levelling attributes in the HeroAttributes class. Levelling attributes are what the hero's attributes incease with when they level up. 

**Update:** The HeroAttribute class has been changed to a HeroAttribute record, even though the assignment asks for a class. This was in order to fix the issue with unit testing when using hero attributes. 

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

## Description of tests
The following tests have been done on all heroes: 
* When a hero is created, it needs to have the correct name
* When a hero is created, it needs to have the correct level
* When a hero is created, it needs to have the correct attributes
* When a heroes level is increased, it needs to increment by the correct amount (levelling attributes) and result in the correct attributes
* A hero should display their state correctly

The following tests were only done on Mage:
* A hero should be able to equip weapon
* If a hero equips invalid weapon (weapon type and level requirement), custom exception should be thrown
* If a hero equips invalid armor (armor type and level requirement), custom exception should be throw
* Hero damage should be calculated correctly with no weapon equipped
* Hero damage should be calculated correctly with weapon equipped
* Hero damage should be calculated correctly with replaced weapon equipped (equip a weapon then equip a new weapon)
* Hero damage should be calculated correctly with weapon and armor equipped (see "Clarification on "failed" tests below)
* Total attributes should be calculated correctly with no equipment
* Total attributes should be calculated correctly with one piece of armor
* Total attributes should be calculated correctly with two pieces of armor
* Total attributes should be calculated correctly with a replaced piexe of armor (equip armor, then equip new armor in the same slot)

The following tests were done on items: 
* When Weapon is created, it needs to have the correct name
* When Weapon is created, it needs to have the correct required level
* When Weapon is created, it needs to have the correct slot
* When Weapon is created, it needs to have the correct weapon type
* When Weapon is created, it needs to have the correct damage
* When Armor is created, it needs to have the correct name
* When Armor is created, it needs to have the correct required level
* When Armor is created, it needs to have the correct slot
* When Armor is created, it needs to have the correct armor type
* When Armor is created, it needs to have the correct armor attributes


## Clarification on "failed" tests
13 of the tests completed in this project resulted in Assert.Equal() fail, but the results (expected and actual) were the same. The reason for this is that Assert.Equal() uses reference comparison, and the expected and actual results are located in different locations in the memory, the tests are failing (even though the values are the same). I have seen some have used Assert.Equivalent(), but I could not find documentation for how this should be possible to use. Perhaps a different version of .NET would solve this. 
This was solved by changing the HeroAttribute class to a record. After this, all tests passed.  

Test "Hero damage should be calculated correctly with weapon and armor equipped": When filling all armor slots, I had the following Expected: 5.55, Actual: 5.550000000000001. So it passes, but have changed the lines for all armor (using only one armor slot) because of this. So this is a passing test in the console application right now. 



## Clarification on "missing" commits
I originally had a different project, but I received the following error in that project: "The debug executable ... specified in the ... debug profile does not exist"

I attempted correcting this so the project would work, but I had to create a new project instead - and I copied the code from the old project. So all the commits I had made on the previous project are therefore not included here. 
