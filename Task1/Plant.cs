using Task1;

using System;
using Task1.Interfaces;

public class Plant : LivingOrganism, IReproducible
{
    public string Type { get; set; }

    public Plant(int energy, int age, double size, string type)
        : base(energy, age, size)
    {
        Type = type;
    }

    public void Reproduce()
    {
        Console.WriteLine($"{Type} має можливість розмножуватися.");
    }
}
