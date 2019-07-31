using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesV2Project {

    public class Membership : ICalcSales {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Fee { get; set; }
        public int Units { get; set; }

        public decimal CalcSales() {
            return (decimal) Fee * Units;
        }

        public Membership(int id, string name, int fee, int units) {
            this.Id = id;
            this.Name = name;
            this.Fee = fee;
            this.Units = units;
        }
    }
}
