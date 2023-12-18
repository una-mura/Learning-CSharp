namespace TransportApp;

using System.Threading;
using System.Security.Cryptography;

public class Race
{
    private readonly Driver driver;
    private readonly Passenger passenger;
    private readonly string startAddress, finalAddress;

    public Race(Driver driver, Passenger passenger, string startAddress, string finalAddress)
    {
        this.driver = driver;
        this.passenger = passenger;
        this.startAddress = startAddress;
        this.finalAddress = finalAddress;
    }

    public void SimulateRace()
    {
        var driverArrivalTime = RandomNumberGenerator.GetInt32(1, 11);
        var raceDurationTime = RandomNumberGenerator.GetInt32(5, 31);
        
        Console.WriteLine($"{passenger.name}, {driver.name} will be arriving in {driverArrivalTime} minutes!\n");

        for (var i = driverArrivalTime; i >= 1 ; i--)
        {
            Console.WriteLine($"{i} minutes until {driver.name}'s arrival.");
            Thread.Sleep(1000);
        }
        
        Console.WriteLine($"\n{driver.name} has arrived at {startAddress}. Race initiated.\n");

        for (var i = raceDurationTime; i >= 1; i--)
        {
            Console.WriteLine($"You are at {i} minutes from your destination.");
            Thread.Sleep(1000);
        }
        
        Console.WriteLine($"\nYou have arrived at {finalAddress}!");
    }
}