using TransportApp;

var newPassenger = new Passenger("Carol");
var newDriver = new Driver("Ryuna");
var newRace = new Race(newDriver, newPassenger, "Boa Esperança", "CPA 1");

newRace.SimulateRace();