using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oopAutos
{
    public class Sale
    {
        public double totalSalesAmount { get; set; }
        public Automobile Automobile { get; set; }
        public Salesman Salesman { get; set; }
        public Customer Customer { get; set; }

        public void sellCar() { }
    }
}