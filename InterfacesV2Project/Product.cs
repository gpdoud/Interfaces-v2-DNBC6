﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesV2Project {

    public class Product : ICalcSales {

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Units { get; set; }

        public decimal CalcSales() {
            return Price * Units;
        }

        public string About() {
            return "About Products";
        }

        public Product(int id, string name, decimal price, int units) {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Units = units;
        }
    }
}
