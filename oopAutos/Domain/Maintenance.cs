﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oopAutos
{
    public class Maintenance
    {
        public bool hasBeenDetailed { get; set; }
        public string detailedServiceHistory { get; set; }

        public void addToServiceHistory() { }
        public void sendToDetailer() { }
    }
}