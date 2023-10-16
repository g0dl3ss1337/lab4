namespace Task3;

public class Vehicle
{
    public double Speed { get; set; }
    public double Size { get; set; }
    public string Type { get; set; }

    public Vehicle(double speed, double size, string type)
    {
        Speed = speed;
        Size = size;
        Type = type;
    }
}
