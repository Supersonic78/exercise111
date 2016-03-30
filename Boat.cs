using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise_10
{
    class Boat : vehicle
    {
        public string BoatType { get; set; }

        public Boat(string boatType, string vehicleType): base ("Boat")
        {
            BoatType = boatType;
        }
        public override string DescribeVehicle()
        {
            return base.DescribeVehicle();
        }
    }
}
