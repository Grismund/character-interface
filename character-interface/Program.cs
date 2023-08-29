// See https://aka.ms/new-console-template for more information

using DefaultNamespace;

Console.WriteLine("Hello, World!");

Character shaman = new Character();
shaman.Name = "Horace";
shaman.Health = 100;
shaman.CharacterClass = CharacterClass.Shaman;
shaman.Status();
shaman.Travel();
shaman.Attack();

Character mage = new Character();
mage.Name = "Merlin";
mage.Health = 80;
mage.CharacterClass = CharacterClass.Mage;
mage.Status();
mage.Travel();
mage.Attack();

Character warrior = new Character();
warrior.Name = "Brutus";
warrior.Health = 120;
warrior.CharacterClass = CharacterClass.Warrior;
warrior.Status();
warrior.Travel();
warrior.Attack();

