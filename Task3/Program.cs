namespace Task3;
using System;

class Program
{
    static void Main()
    {
        
        Road road = new Road(1000, 3.5, 3, 3); 
        Vehicle vehicle = new Vehicle(90, 5, "Автомобіль");
        Vehicle truck = new Vehicle(70, 10, "Вантажівка");
        Vehicle bus = new Vehicle(60, 15, "Автобус");

        TrafficSimulation simulation = new TrafficSimulation();
        
        simulation.SimulateMovement(vehicle, road);
        simulation.SimulateMovement(truck, road);
        simulation.SimulateMovement(bus, road);

        Console.ReadLine();
    }
}

