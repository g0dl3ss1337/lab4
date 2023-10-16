namespace Task1;

using System;
using System.Collections.Generic;
using Task1.Interfaces;

public class Ecosystem
{
    private List<LivingOrganism> organisms;

    public Ecosystem()
    {
        organisms = new List<LivingOrganism>();
    }

    public void AddOrganism(LivingOrganism organism)
    {
        organisms.Add(organism);
    }

    public void Interact()
    {
        foreach (var organism in organisms)
        {
            if (organism is IReproducible)
            {
                ((IReproducible)organism).Reproduce();
            }

            if (organism is IPredator)
            {
                foreach (var canHunt in organisms)
                {
                    if (organism != canHunt)
                    {
                        ((IPredator)organism).Hunt(canHunt);
                    }
                }
            }
        }
    }
}

