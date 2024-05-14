using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildSphere
{
    public class Sphere
    {
        private int radius;
        private int mass;

        public Sphere(int radius, int mass)
        {
            this.radius = radius;
            this.mass = mass;
        }

        public int GetRadius()
        {
            return this.radius;
        }

        public int GetMass()
        {
            return this.mass;
        }


        public double GetVolume()
        {
            // V = 4/3 π r³
            return Math.Round((4.0/3 * Math.PI) * Math.Pow(this.radius, 3) , 5);
        }
        public double GetSurfaceArea()
        {
            //4πr^2,
            return Math.Round(4 * Math.PI * Math.Pow(this.radius,2), 5);
        }

        public double GetDensity()
        {
            return Math.Round(this.mass / this.GetVolume(), 5);
        }
    }
}
