using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
   class Car
    {
        public Car(){
            Year = 2016;
            Make = "Mercedes";
            Model = "S";
            EngineNoise = "thrumthrumthrum";
            HonkNoise = "vromp";
            IsDriveable = true;
        }
        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string engine)
        {
            Console.WriteLine(engine);
        }
        public void MakeHonkNoise(string honk)
        {
            Console.WriteLine(honk);
        }
    }
}
