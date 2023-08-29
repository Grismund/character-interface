namespace DefaultNamespace;

public class Character : ICharacter
{
    public string Name { get; set; }
    public int Health { get; set; }
    public CharacterClass CharacterClass { get; set; }
    
    public void Travel()
    {
        Console.WriteLine("You travel to a new location.");
    }
    
    public void Status()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Health: " + Health);
        Console.WriteLine("Class: " + CharacterClass);
    }
    
    public void Attack()
    {
        if (CharacterClass == CharacterClass.Mage)
        {
            Console.WriteLine("You cast a spell!");
        } else if (CharacterClass == CharacterClass.Shaman)
        {
            Console.WriteLine("You sick your wolves on them!");
        }
        else
        {
            Console.WriteLine("You do a basic attack.");
        }
    }
}