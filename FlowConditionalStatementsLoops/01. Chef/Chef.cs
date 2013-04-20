using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Potato and Carrot are replaced with Vegetable in order not to repeat code 
/// DRY principle (Don't Repeat Yourself).
/// </summary>
public class Chef
{
    public Vegetable GetVegetable()
    {
        return new Vegetable();
    }

    public Vegetable Peel(Vegetable vegetable)
    {
        vegetable.HasBeenPeeled = true;

        return vegetable;
    }

    public Vegetable Cut(Vegetable vegetable)
    {
        vegetable.HasBeenCut = true;

        return vegetable;
    }

    public Bowl GetBowl()
    {
        return new Bowl();
    }

    public void Cook(Vegetable vegetable)
    {
        vegetable = this.GetVegetable();

        this.Peel(vegetable);

        this.Cut(vegetable);

        Bowl bowl = this.GetBowl();
        bowl.BowlList.Add(vegetable);
    }
}