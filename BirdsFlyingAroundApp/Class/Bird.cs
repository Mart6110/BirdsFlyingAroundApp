using BirdsFlyingAroundApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundApp.Class
{
    public abstract class Bird
    {
        protected double Longitude;
        protected double Latitude;
        public Bird(double longitude, double latitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }

        public double GetLongitude()
        {
            return Longitude;
        }
        public double GetLatitude()
        {
            return Latitude;
        }
    }
}
