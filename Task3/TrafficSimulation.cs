using System.Text;

namespace Task3;

public class TrafficSimulation
{
    public void SimulateMovement(Vehicle vehicle, Road road)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine($"Симуляція руху {vehicle.Type} на шляху довжиною {road.Length} метрів з {road.NumberOfLanes} полосами.");
        
        double time = road.Length / (vehicle.Speed / 3.6);

        Console.WriteLine($"Транспортний засіб потребує {time} секунд для пройдення цього шляху.\n");

    }
}
