using PocketMonsters;

var pocketMonsters = new List<Monster>()
{
    new Monster(0, "Atrocious Dragon Monster", "Dragonair"),
    new Monster(1, "Gracious Dragon Monster", "Gyarados"),
    new Monster(2, "Flaming Dragon Monster", "Charizard"),
    new Monster(3, "Dusky Ghost Monster", "Mismagius"),
    new Monster(4, "Aurora Borealis Monster", "Suicune"),
    new Monster(5, "Time Traveler Monster", "Celebi"),
    new Monster(6, "Blazing Rooster Monster", "Blaziken"),
    new Monster(7, "Flowing Gown Monster", "Gardevoir"),
    new Monster(8, "Shifting Weather Monster", "Castform"),
    new Monster(9, "Head Butting Monster", "Rampardos"),
    new Monster(10, "Aura Reader Monster", "Lucario"),
    new Monster(11, "Plasma Bulb Monster", "Rotom"),
    new Monster(12, "Suspicious Mushroom Monster", "Amoonguss"), //sus
    new Monster(13, "Trash Bag Monster", "Trubbish"),
    new Monster(14, "Astral Body Monster", "Gothitelle"),
    new Monster(15, "Primitive Turtle Monster", "Carracosta"),
    new Monster(16, "Fiery Robe Monster", "Delphox"),
    new Monster(17, "Mock Kelp Monster", "Dragalge"),
    new Monster(18, "Royal Sword Monster", "Aegislash"),
    new Monster(19, "Keen Eye Monster", "Meowstic")
};

var game = true;

Console.WriteLine("Greetings, trainer! Who are you?");

Console.Write("Name: ");

var trainer = new Trainer(Console.ReadLine());
var monsterDex = new Dex(trainer);

while (game)
{
    Console.Write("\nDo you wish to adventure yourself? (Y/N): ");
    var input = Console.ReadLine();

    switch (input)
    {
        case "y" or "Y" or "yes" or "YES" or "Yes":
            monsterDex.AddEncounter(pocketMonsters[new Random().Next(20)]);
            break;
        
        case "n" or "N" or "no" or "NO" or "No":
            game = false;
            break;
        
        default:
            Console.WriteLine("Invalid input. Try again!");
            break;
    }
}

Console.WriteLine("\n========================================================================\n");
Console.WriteLine($"{trainer.Name}'s Sightings Report\n");

if (monsterDex.database.Count is 0)
{
    Console.WriteLine("Nothing to report!");
}
else
{
    foreach (var monster in pocketMonsters.Where(monster => monsterDex.database.ContainsKey(monster)))
    {
        var sightings = monsterDex.database[monster];
        Console.WriteLine($"{monster.Name} (ID #{monster.IdNumber})");
        Console.WriteLine($"  Description: {monster.Description}");
        Console.WriteLine($"  Sightings: {sightings}\n");
    }
}