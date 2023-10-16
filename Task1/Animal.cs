namespace Task1;

using System;
using System.Drawing;
using System.Text;
using Task1.Interfaces;

public class Animal : LivingOrganism, IReproducible, IPredator
{
    public string Species { get; set; }

    public Animal(int energy, int age, double size, string species)
        : base(energy, age, size)
    {
        Species = species;
    }


    public void Reproduce()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine($"{Species} має можливість розмноженя.");
    }

    public void Hunt(LivingOrganism organism)
    {
        if (organism is Animal otherAnimal && otherAnimal.Size < Size)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"{Species} може полювати на {otherAnimal.Species}.");
        }
        else
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"{Species} не може полювати на цей організм.");
        }
    }
}


