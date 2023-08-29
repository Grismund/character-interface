namespace DefaultNamespace;

public interface ICharacter
{
    public string Name { get; set; }
    public int Health { get; set; }
    public void Travel();
    
    public CharacterClass CharacterClass { get; set; }

    public void Status();
}