using BirdsFlyingAroundApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundApp.Class
{
    public class FlyingBird : Bird, IFly
    {
        Random rnd = new Random();
        protected double longitude;
        protected double latitude;
        protected double altitude;
        public FlyingBird(double longitude, double latitude) : base(longitude, latitude)
        {
            altitude = rnd.Next(1000);
        }

        public double GetAltitude()
        {
            return altitude;
        }
    }
}
