using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cSharp
{
    public class Automobile
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public double price { get; set;}
        public  int dayOnLot { get; set; }
        public string promotionalOffers { get; set; }
        public double marketValue { get; set; }
        public string purchasedByName { get; set; }
        public string purchasedByAddress { get; set; }
        public int purchasedByPhone { get; set; }
        public string soldBy { get; set; }
        public string category { get; set; }
        public double totalSalesAmount { get; set; }
        public bool hasBeenDetailed { get; set; }
        public string detailedServiceHistory { get; set; }
        public int carLotParkingSpace { get; set; }

        public void determineValueOfCar() { }
        public void sellCar() { }
        public void moveCarOnLot() { }
        public void addToServiceHistory() { }
        public void addPromotionalOffer() { }
        public void sendToDetailer() { }
        public void discountCar() { }
        public void printCarDetails() { }
        public void retreiveCarFromDatabase() { }
        public void saveCarToDatabase() { }

    }
}