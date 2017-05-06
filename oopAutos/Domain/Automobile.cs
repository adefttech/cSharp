using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oopAutos
{
   public class Automobile
   {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public double price { get; set; }
        public int daysOnLot { get; set; }        
        public double marketValue { get; set; }
        public string category { get; set; }
        public int carLotParkingSpace { get; set; }

        public void determineValueOfCar() { }
        
    }
}