using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildACar;
public class FuelTankDisplay : IFuelTankDisplay
{
    public double FillLevel
    {
        get
        {
            return Math.Round(this.FillLevel, 2);
        }
    }

    public bool IsOnReserve
    {
        get
        {
            return (this.FillLevel < 5);
        }
    }

    public bool IsComplete
    {
        get
        {
            return this.FillLevel == 60;
        }

    }
}