// See https://aka.ms/new-console-template for more information
using RPG_Heroes.Heroes;
using RPG_Heroes.Items;
using static System.Net.Mime.MediaTypeNames;
Console.WriteLine("Hello, World!");

Mage alfredTheMage = new Mage("Alfred");
Console.WriteLine($"{alfredTheMage.Name} is created");

//Weapon weapon1 = new Weapon("Isildur", 1, RPG_Heroes.Enum.Enums.WeaponType.Sword, 5);
//Console.WriteLine($"{alfredTheMage.Name} attempts to equip {weapon1.Name}");

//alfredTheMage.EquipWeapon(weapon1);

Weapon weapon2 = new Weapon("GandalfStick", 1, RPG_Heroes.Enum.Enums.WeaponType.Staff, 10);
Console.WriteLine($"{alfredTheMage.Name} attempts to equip {weapon2.Name}");

alfredTheMage.EquipWeapon(weapon2);

Armor armor1 = new Armor(RPG_Heroes.Enum.Enums.ArmorType.Leather, "Leather Vest", new(1, 1, 8, 1, 1, 5), RPG_Heroes.Enum.Enums.Slot.Body, 1);
Console.WriteLine($"{alfredTheMage.Name} is wearing {armor1.Name} on his body");

alfredTheMage.Damage();