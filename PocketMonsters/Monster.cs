namespace PocketMonsters;

public class Monster
{
    public int IdNumber { get; }
    public string Description { get; }
    public string Name { get; }


    public Monster(int id, string description, string name)
    {
        IdNumber = id;
        Description = description;
        Name = name;
    }
}