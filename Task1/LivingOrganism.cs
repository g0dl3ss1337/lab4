namespace Task1;

using System;

public class LivingOrganism
{
    public int Energy { get; set; }
    public int Age { get; set; }
    public double Size { get; set; }

    public LivingOrganism(int energy, int age, double size)
    {
        Energy = energy;
        Age = age;
        Size = size;
    }
}
