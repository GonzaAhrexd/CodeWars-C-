﻿using System;

public class Car : ICar
{
    public IFuelTankDisplay fuelTankDisplay;

    private IEngine engine;

    private IFuelTank fuelTank;

    public Car()
    {

    }

    public Car(double fuelLevel)
    {

    }
}