using System;


public class Engine : IEngine
{
    private bool isRunning = false;
    public bool IsRunning
    {
        get
        {
            return this.isRunning;
        }
    }

    public void Start()
    {
        this.isRunning = true;
    }

    public void Stop()
    {
        this.isRunning = false;
    }

    public void Consume(double liters)
    {
        FuelTank fuel = new FuelTank();
        fuel.Consume(liters);
    }
}