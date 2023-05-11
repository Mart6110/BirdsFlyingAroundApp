using BirdsFlyingAroundApp.Class;
using BirdsFlyingAroundApp.Interface;
using System;
using System.Collections.Generic;

namespace BirdsFlyingAroundApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bird> birds = new List<Bird>();

            FlyingBird flyingBird = new FlyingBird(111, 222);
            NonFlyingBird nonFlyingBird = new NonFlyingBird(234, 567);

            birds.Add(flyingBird);
            birds.Add(nonFlyingBird);

            foreach(Bird bird in birds)
            {
                Console.WriteLine(bird.GetType().Name);
                Console.WriteLine("Longitude: " + bird.GetLongitude().ToString());
                Console.WriteLine("Latitude: " + bird.GetLatitude().ToString());
                if (bird.GetType().Name == "FlyingBird")
                {
                    Console.WriteLine("Altitude: " + flyingBird.GetAltitude());
                }
                Console.WriteLine();
            }
        }
    }
}
