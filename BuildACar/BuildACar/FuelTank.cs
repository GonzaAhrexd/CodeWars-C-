using System;
using System.ComponentModel.Design;

public class FuelTank : IFuelTank
{
    private double fillLevel = 20;
    private double isOnReserve;
    private bool isComplete;
    public double FillLevel { get; }

    public bool IsOnReserve
    {
        get
        {
            return this.fillLevel < 5;
        }
    }

    public bool IsComplete { get; }

    public void Consume(double liters)
    {
        this.fillLevel -= liters;

    }

    public void Refuel(double liters)
    {
        if(this.fillLevel + liters > 60)
        {
            this.fillLevel = 60;
        }
        else
        {
            this.fillLevel += liters;
        }
    }
}