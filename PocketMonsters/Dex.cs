namespace PocketMonsters;

public class Dex
{
    public readonly Dictionary<Monster, int> database = new();
    public Trainer? DexTrainer { get; }

    
    public Dex(Trainer dexTrainer)
    {
        DexTrainer = dexTrainer;
    }

    public void AddEncounter(Monster foundMonster)
    {
        if (database.TryAdd(foundMonster, 1))
        {
            Console.WriteLine($"{foundMonster.Name} has been added to your Dex database!");
        }
        else
        {
            database[foundMonster]++;
            Console.WriteLine($"Encounter with {foundMonster.Name} has been registered in your Dex.");
        }
    }
}