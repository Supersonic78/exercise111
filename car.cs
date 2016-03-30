using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise_10
{
    public class car : vehicle
    {
        public bool _EngineIsRunning;
        public string CarModel { get; set; }
        public car(string carModel, bool _engineIsRunning ) : base ("Car")
        {
            CarModel = carModel;
            _EngineIsRunning = false;
                
        }
       

        public void StartEngine()
        {
            _EngineIsRunning = true;
        }

        public void StopEngine()
        {
            _EngineIsRunning = false;
        }
        public override string DescribeVehicle()
        {
            return base.DescribeVehicle();
        }
    }
}
