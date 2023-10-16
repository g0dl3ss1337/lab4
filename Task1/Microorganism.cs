using Task1;

using System;
using System.Text;
using Task1.Interfaces;

public class Microorganism : LivingOrganism, IReproducible
{
    public string Name { get; set; }

    public Microorganism(int energy, int age, double size, string name)
        : base(energy, age, size)
    {
        Name = name;
    }

    public void Reproduce()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine($"Мікроорганізм {Name} має можливість розмножуватися.");
    }
}
