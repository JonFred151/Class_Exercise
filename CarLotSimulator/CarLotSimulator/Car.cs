﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        //public Car()
        //{
        //    CarLot.NumberOfCars++;
        //}

        public string Make {  get; set; }
        public int  year {  get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public string  IsDriveable { get; set; }

        
        public void MakeEngineNoise(string EngineNoise)
        {
            Console.WriteLine($"{EngineNoise}");
        }

        public void MakeHonkNoise(string HonkNoise)
        {
            Console.WriteLine($"{HonkNoise}");
        }
        

    }
}
