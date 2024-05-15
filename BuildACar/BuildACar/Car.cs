using System;

public class Car : ICar{
    public IFuelTankDisplay fuelTankDisplay;

    private IEngine engine;

    private IFuelTank fuelTank;

  

    public Car(double fuelLevel)
    {
        IFuelTank tank = new FuelTank();

            tank.Refuel(fuelLevel);
        this.fuelTank = tank;
    }

    public bool EngineIsRunning
    {
        get
        {
            return this.engine.IsRunning;
        }
    }

    public void EngineStart()
    {
        this.engine.Start();
    }

    public void EngineStop()
    {
        this.engine.Stop();
    }

    public void Refuel(double liters)
    {
        this.fuelTank.Refuel(liters);
    }

    public void RunningIdle()
    {
        this.fuelTank.Consume(0.0003);
    }
}